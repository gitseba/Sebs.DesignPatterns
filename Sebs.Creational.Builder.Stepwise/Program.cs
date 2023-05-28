using Sebs.Creational.Builder.Stepwise.Builders;
using Sebs.Creational.Builder.Stepwise.Models;

namespace Sebs.Creational.Builder.Stepwise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = CarBuilder.Create() // Create will return ISpecifyCarType
               .OfType(CarType.Sedan)     // That's why only OfType method is visible
               .WithWheels(16)            // OfType returns ISpecifyWheelSize , that's why only WithWheels is visible
               .Build();                  // Finally build the car

            Console.ReadLine();
        }
    }
}