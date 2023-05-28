namespace Sebs.Structural.Adapter.Printers
{
    public class HpPrinter
    {
        private readonly IHpPrinter _epsonPrinter;

        public HpPrinter(IHpPrinter epsonPrinterAdapter)
        {
            this._epsonPrinter = epsonPrinterAdapter;
        }

        public void Print() 
        {
            _epsonPrinter.PrintDocument();
        }
    }
}
