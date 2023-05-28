namespace Sebs.Behavioral.Observable.TeacherStudents
{
    public class Teacher : ISubject
    {
        private readonly List<IObserver> _observers;

        public Teacher()
        {
            _observers = new List<IObserver>();
        }

        /// <summary>
        /// Register an observer to subject
        /// </summary>
        /// <param name="observer"> Observer registered </param>
        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Unregister an Observer from subject
        /// </summary>
        /// <param name="observer"></param>
        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notify all registered observers
        /// </summary>
        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Updated(observer, message);
            }
        }
    }
}
