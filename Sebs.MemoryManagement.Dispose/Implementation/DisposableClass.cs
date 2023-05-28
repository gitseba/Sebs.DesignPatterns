using System;
using System.Runtime.InteropServices;

namespace Sebs.MemoryManagement.Dispose.Implementation
{
    /// <summary>
    /// Purpose: https://stackoverflow.com/questions/538060/proper-use-of-the-idisposable-interface
    /// 
    /// The point of Dispose is to free unmanaged resources. It needs to be done at some point, otherwise they will never be cleaned up. 
    /// The garbage collector doesn't know how to call DeleteHandle() on a variable of type IntPtr, 
    /// it doesn't know whether or not it needs to call DeleteHandle().
    /// Anything you've used P/Invoke calls to get outside of the nice comfy world of everything available to you 
    /// in the .NET Framework is unmanaged – and you're now responsible for cleaning it up.
    /// 
    /// The object that you've created needs to expose some method, that the outside world can call, in order to clean up unmanaged resources.
    /// So you make your object expose the IDisposable interface, and that way you promise that you've written that single method 
    /// to clean up your unmanaged resources.
    /// And you're done. 
    /// 
    ///  - Except you can do better.
    ///  
    /// What if your object has allocated a 250MB System.Drawing.Bitmap (i.e. the .NET managed Bitmap class) as some sort of frame buffer?
    /// Sure, this is a managed .NET object, and the garbage collector will free it. 
    /// But do you really want to leave 250MB of memory just sitting there waiting for the garbage collector
    /// to eventually come along and free it? What if there's an open database connection? 
    /// 
    /// Surely we don't want that connection sitting open, waiting for the GC to finalize the object.
    /// If the user has called Dispose() (meaning they no longer plan to use the object) why not get rid 
    /// of those wasteful bitmaps and database connections?
    /// So now we will:
    /// - get rid of unmanaged resources(because we have to), and
    /// - get rid of managed resources(because we want to be helpful)
    /// 
    /// And all is good, except you can do better!
    /// 
    /// What if the person forgot to call Dispose() on your object? Then they would leak some unmanaged resources!
    /// Note: They won't leak managed resources, because eventually the garbage collector is going to run, on a background thread, 
    /// and free the memory associated with any unused objects. 
    /// This will include your object, and any managed objects you use (e.g. the Bitmap and the DbConnection).
    /// 
    /// If the person forgot to call Dispose(), we can still save their bacon! We still have a way to call it for them:
    /// - when the garbage collector finally gets around to freeing(i.e.finalizing) our object.
    /// 
    /// The destruction of our object by the Garbage collector is the perfect time to free those pesky unmanaged resources. 
    /// We do this by overriding the Finalize() method.
    /// Note: In C#, you don't explicitly override the Finalize() method. 
    /// You write a method that looks like a C++ destructor, and the compiler takes that to be your implementation of the Finalize() method.
    /// 
    /// But there's a bug in that code. You see, the garbage collector runs on a background thread;
    /// you don't know the order in which two objects are destroyed. It is entirely possible that in your Dispose() code,
    /// the managed object you're trying to get rid of (because you wanted to be helpful) is no longer there: Dispose(); //<--Warning: subtle bug! Keep reading!
    /// 
    /// So what you need is a way for Finalize() to tell Dispose() that it should not touch any managed resources 
    /// (because they might not be there anymore), while still freeing unmanaged resources.
    /// The standard pattern to do this is to have Finalize() and Dispose() both call a third(!) method; 
    /// where you pass a Boolean saying if you're calling it from Dispose() (as opposed to Finalize()), 
    /// meaning it's safe to free managed resources.
    /// 
    /// And all is good, except you can do better!
    /// 
    /// If the user calls Dispose() on your object, then everything has been cleaned up.
    /// Later on, when the garbage collector comes along and calls Finalize, it will then call Dispose again.
    /// Not only is this wasteful, but if your object has junk references to objects you already disposed of from the last call 
    /// to Dispose(), you'll try to dispose them again!
    /// 
    /// When the user calls Dispose(): the handle of the unmanaged resource is destroyed. Later when the garbage collector runs, 
    /// it will try to destroy the same handle again.
    /// The way you fix this is tell the garbage collector that it doesn't need to bother finalizing the object – 
    /// its resources have already been cleaned up, and no more work is needed. 
    /// 
    /// You do this by calling GC.SuppressFinalize() in the Dispose() method.
    /// 
    /// Now that the user has called Dispose(), we have:
    ///  - freed unmanaged resources
    ///  - freed managed resources
    ///  There's no point in the GC running the finalizer – everything's taken care of.
    ///  
    /// Created by: sebde
    /// Created at: 5/26/2023 10:51:25 PM
    /// </summary>
    public class DisposableClass : IDisposable
    {
        // A flag to track whether the object has been disposed or not
        private bool disposed = false;

        // Disposable resources
        private StreamWriter disposableResource;

        // Non-disposable resources:
        // IntPtr is a .NET framework struct that represents a pointer or a handle to an unmanaged memory location.
        // It is primarily used to interact with code or APIs that deal with unmanaged resources,
        // such as native libraries, operating system functions, or hardware interfaces.
        private IntPtr nonDisposableResource;

        public DisposableClass()
        {
            // Initialize resources
            string filePath = "output.txt";
            disposableResource = new StreamWriter(filePath);


            // Allocate unmanaged memory
            int size = 4; // 4 bytes
            nonDisposableResource = Marshal.AllocHGlobal(size);

            // Write data to the unmanaged memory
            int value = 42;
            Marshal.WriteInt32(nonDisposableResource, value);

            // Read data from the unmanaged memory
            int readValue = Marshal.ReadInt32(nonDisposableResource);
        }

        // Dispose method implementation
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected Dispose method to handle resource disposal
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    disposableResource.Dispose();

                }

                // Dispose unmanaged resources
                // ...
                // Release the unmanaged memory
                Marshal.FreeHGlobal(nonDisposableResource);

                disposed = true;
            }
        }

        // Finalizer (destructor) - called by the garbage collector
        ~DisposableClass()
        {
            Dispose(false);
        }

        #region Note

        ///<summary>
        /// If your object descends from an object that implements Dispose,
        /// then don't forget to call their base Dispose method when you override Dispose:
        /// </summary>
        //public override void Dispose()
        //{
        //    try
        //    {
        //        Dispose(true); //true: safe to free managed resources
        //    }
        //    finally
        //    {
        //        base.Dispose();
        //    }
        //}
        #endregion
    }
}
