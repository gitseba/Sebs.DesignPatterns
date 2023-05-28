namespace Sebs.Structural.Adapter.Printers
{
    public interface IHpPrinter
    {
        void PrintDocument();
        int DocumentsInQueue();
    }
}
