namespace Sebs.Behavioral.Observable.TeacherStudents
{
    public interface ISubject
    {
        /// <summary>
        /// Register observers
        /// </summary>
        /// <param name="obj"> observer </param>
        void Register(IObserver obj);

        /// <summary>
        /// Unregister observers
        /// </summary>
        /// <param name="obj"> observer </param>
        void Unregister(IObserver obj);
    }
}