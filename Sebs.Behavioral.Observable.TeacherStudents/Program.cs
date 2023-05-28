using Sebs.Behavioral.Observable.TeacherStudents;

namespace Sebs.Behavioral.Observable.TeacherStudentsStudents
{
    /// <summary>
    /// The Observable pattern
    ///     is a behavioral design pattern that provides a way to notify multiple objects, known as observers, 
    ///     about changes or events occurring in a subject or observable object.

    ///    The pattern consists of two main components:

    ///    Observable(Subject) :
    ///        The observable object maintains a list of observers and provides methods to add, remove, 
    ///        or notify observers.
    ///        It typically includes an event or a set of methods that observers can subscribe to 
    ///        in order to receive notifications.

    ///    Observer:
    ///        The observer is an object that wants to be notified about changes or events occurring 
    ///        in the observable object.
    ///        It defines an interface or implements methods that the observable object can call 
    ///        when a relevant event occurs.

    /// The observable object keeps track of its observers and notifies them when certain conditions 
    /// or events take place.Observers can react to the notification by performing specific actions 
    /// or updating their internal state accordingly.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            /* Observable Pattern */
            Teacher teacher = new();
            teacher.Register(new Students() { Name = "Student A" });
            teacher.Register(new Students() { Name = "Student B" });
            teacher.Register(new Students() { Name = "Student C" });

            Console.WriteLine("Teacher: Notify all the subscribed students!\n");
            teacher.NotifyObservers("Bring your laptop to the course on Wednesday!");

            Console.ReadLine();
        }
    }
}