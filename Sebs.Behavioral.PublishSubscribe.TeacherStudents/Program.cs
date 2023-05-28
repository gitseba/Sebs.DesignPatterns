using Sebs.Behavioral.PublishSubscribe.TeacherStudents;

namespace Sebs.Behavioral.PublishSubscribe.TeacherStudentsStudents
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Initialize pub class object
            TeacherPublisher publisher = new TeacherPublisher();

            //Subscriber 1 to the event registration
            publisher.OnChange += (sender, e) 
                => Console.WriteLine("Subscriber 1! Notification from teacher received: " + e.Note);

            //Subscriber 2 to the event registration
            publisher.OnChange += (sender, e) 
                => Console.WriteLine("Subscriber 2! Notification from teacher received: " + e.Note);

            //Subscriber 3 to the event registration
            publisher.OnChange += (sender, e) 
                => Console.WriteLine("Subscriber 3! Notification from teacher received: " + e.Note);

            //raise the event
            publisher.Raise("Note: Bring the books to the course on Friday!");

            //After this Raise() method is called all subscribers callback methods will get invoked
            Console.WriteLine("Press enter to terminate!");

            Console.ReadLine();
        }
    }
}