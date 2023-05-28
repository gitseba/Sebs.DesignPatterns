namespace Sebs.Behavioral.Observable.TeacherStudents
{
    public interface IObserver
    {
        /// <summary>
        /// Update the observer, used by subject
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        void Updated(object sender, string msg);
    }
}

