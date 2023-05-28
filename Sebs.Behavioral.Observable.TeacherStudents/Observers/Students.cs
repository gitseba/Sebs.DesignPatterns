namespace Sebs.Behavioral.Observable.TeacherStudents
{
    public class Students : IObserver
    {
        public string? Name { get; set; }

        /// <summary>
        /// Update observer with message from subject
        /// </summary>
        public void Updated(object sender, string msg)
        {
            Console.WriteLine($"Name: {(sender as Students)?.Name} received from teacher - {msg}");
        }
    }
}
