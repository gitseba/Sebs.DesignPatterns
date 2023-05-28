namespace Sebs.SOLID.InterfaceSegregationPrinciple
{
    //********************************************** ISP applied
    //Interfaces should be more atomic, so it could be implemented separated, instead of adding not need implementation to a class.
    public interface IPrinter
    {
        public void Print(DocumentModel d);
    }
}