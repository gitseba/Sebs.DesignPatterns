namespace Sebs.Behavioral.PublishSubscribe.TeacherStudents
{
    public class NoteEventArgument : EventArgs
    {
        public string Note { get; }

        public NoteEventArgument(string note)
        {
            Note = note;
        }
    }
}
