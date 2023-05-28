namespace Sebs.SOLID.InterfaceSegregationPrinciple
{
    // What happens if we try to create a printer class that knows only to print?
    /// <summary>
    /// This class is not ok to implement IMachine interface because is it has functions that are not provided
    /// And the questions that arise here is how should we treat the not implemented methods?
    /// Throw exceptions, tell the user that he has the function, but the printer doesn't support it...
    /// </summary>
    public class OldFunctionPrinter : IMachine
    {
        public void Print(DocumentModel d)
        {
            //implement printing logic
        }

        public void Fax(DocumentModel d)
        {
            throw new NotImplementedException();
        }

        public void Scan(DocumentModel d)
        {
            throw new NotImplementedException();
        }
    }
}