using Sebs.Creational.FactoryMethod.Factories;
using Sebs.Creational.FactoryMethod.Models;

namespace Sebs.Creational.FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {

            var carModel = ObjectFactory.Instance<CarModel>();

            Console.ReadLine();
        }
    }
}