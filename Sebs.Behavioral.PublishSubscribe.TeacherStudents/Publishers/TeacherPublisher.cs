namespace Sebs.Behavioral.PublishSubscribe.TeacherStudents
{
    public class TeacherPublisher
    {
        //OnChange property containing all the list of subscribers callback methods.
        //This is generic EventHandler delegate where we define the type of argument want to send 
        //while raising our event, MyEventArgs in our case.
        public event EventHandler<NoteEventArgument> OnChange = delegate { };

        public void Raise(string message)
        {
            //Initialize MyEventArgs object with some random value
            NoteEventArgument eventArgs = new NoteEventArgument(message);

            //Create list of exception
            List<Exception> exceptions = new List<Exception>();

            //Invoke OnChange Action by iterating on all subscribers event handlers
            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    //pass sender object and eventArgs while
                    handler.DynamicInvoke(this, eventArgs);
                }
                catch (Exception e)
                {
                    //Add exception in exception list if occured any
                    exceptions.Add(e);
                }
            }

            //Check if any exception occured while invoking the subscribers event handlers
            if (exceptions.Any())
            {
                //Throw aggregate exception of all exceptions occured while invoking subscribers event handlers
                throw new AggregateException(exceptions);
            }
        }
    }
}
