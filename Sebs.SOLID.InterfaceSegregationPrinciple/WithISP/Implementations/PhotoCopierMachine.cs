namespace Sebs.SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Now this class needs to implement only what it can provide by hardware limitations.
    /// If the machine doesn't know how to Fax, I don't need to implement an interface for it.
    /// </summary>
    public class PhotoCopierMachine : IPrinter, IScanner
    {
        public void Print(DocumentModel d)
        {
            Console.WriteLine("Printing page...");
        }

        public void Scan(DocumentModel d)
        {
            Console.WriteLine("Scanning page...");
        }
    }
}