namespace Sebs.SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// This class is ok to implement IMachine interface because is multi function
    /// </summary>
    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(DocumentModel d)
        {
            //implement faxing logic
        }

        public void Print(DocumentModel d)
        {
            //implement printing logic
        }

        public void Scan(DocumentModel d)
        {
            //implement scanning logic
        }
    }
}