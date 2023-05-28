using Sebs.Creational.Builder.Stepwise.Abstractions;
using Sebs.Creational.Builder.Stepwise.Models;

namespace Sebs.Creational.Builder.Stepwise.Builders
{
    public class CarBuilder
    {
        /// <summary>
        /// This class acts like a wizard where it implements all the interfaces and 
        /// after the create method take place, the methods are chained in a specific order based on interfaces
        /// </summary>
        private class Implementation : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private CarModel car = new CarModel();
            public ISpecifyWheelSize OfType(CarType carType)
            {
                car.CarType = carType;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch (car.CarType)
                {
                    case CarType.Crossover when size < 17 || size > 20:
                    case CarType.Sedan when size < 15 || size > 17:
                    default: throw new ArgumentException($"Wrong size of wheel for {car.CarType}");
                }
                car.WheelSize = size;
                return this;
            }

            public CarModel Build()
            {
                return car;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Implementation();
        }
    }
}