namespace Sebs.Structural.Adapter.Printers
{
    ///*Notes
    ///Adapter pattern is composed of 3 classes: 
    ///     => One that is where the functionality resides, but we don't have access to (maybe a sealed Library)
    ///     => The adapter class that will inherit interface from sealed functionality
    ///     => The class that will be used instead of the one with sealed functionality
    ///     In this case, EpsonPrinter has sealed functionality and is of type IEpsonPrinter
    ///     HpPrinter accepts only IHpPrinter type, so I will need an adapter for this.
    ///     The adapter will take Epson functionality and transfer it to HpPrinter


    /// <summary>
    /// The Adapter design pattern is a structural pattern that allows incompatible interfaces to work together. 
    /// The question here would be: What incompatible interfaces even mean?
    /// For example: if an interface is being declared and used in a 3rd party library, then I wouldn't get access to it's functionality.
    /// But if I adapt a new interface to the 3rd party library, I will get the chance to implement my own functionality
    /// By doing so, we allow objects from different interfaces to exchange data.
    /// 
    /// This type of pattern becomes very important when you don't controll all parts of those code. 
    /// If the EpsonPrinter and the Printer classes were both defined in 3rd party libraries that you can't modify, 
    /// you would use this pattern to connect them together.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------------------
            //Plug - Let's say that this class would be boxed in a Class Library and don't have access to it's functionality
            IEpsonPrinter epsonPrinter = new EpsonPrinter();
            //--------------------------------------------------------------------------------------------------------------

            //Adapter - This adapter is being created locally so I could switch from IEpsonPrinter to IHpPrinter interface
            IHpPrinter adaptToHpPrinter = new EpsonToHpPrinterAdapter(epsonPrinter);

            //Socket
            var hpPrinter = new HpPrinter(adaptToHpPrinter);
            //This hpPrinter will use Epson functionality to print
            hpPrinter.Print();

            Console.ReadKey();
        }
    }
}