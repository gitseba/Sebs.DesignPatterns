namespace Sebs.Structural.Adapter.Printers
{
    /// <summary>
    /// This class stand in between IHpPrinter and IEpsonPrinter interfaces
    /// IHpPrinter implements it and IEpsonPrinter receives it through constructor
    /// Thr primary goal of the Adapter pattern is to have a class to makes class B act like class A by translating, 
    /// as best as possible the behavior from one to the other. 
    /// </summary>
    public class EpsonToHpPrinterAdapter : IHpPrinter
    {
        private int _queueCount;
        public IEpsonPrinter EpsonPrinter { get; }

        public EpsonToHpPrinterAdapter(IEpsonPrinter epsonPrinter)
        {
            EpsonPrinter = epsonPrinter;
            _queueCount = 0;
        }

        public void PrintDocument()
        {
            _queueCount++;
            EpsonPrinter.Print();
            _queueCount--;
        }

        public int DocumentsInQueue()
        {
            return _queueCount;
        }
    }
}
