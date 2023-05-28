namespace Sebs.Structural.Adapter.Printers
{
    public class EpsonPrinter : IEpsonPrinter
    {
        public void Print()
        {
            Console.WriteLine("Epson prints... with locally implementation of Hp Printer.");
        }
    }
}
