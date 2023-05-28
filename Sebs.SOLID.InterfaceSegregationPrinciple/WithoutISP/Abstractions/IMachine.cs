namespace Sebs.SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Purpose: Printers interface
    /// Created by: sebde
    /// Created at: 5/28/2023 5:26:50 PM
    /// </summary>
    public interface IMachine
    {
        void Print(DocumentModel d);
        void Scan(DocumentModel d);
        void Fax(DocumentModel d);
    }
}

