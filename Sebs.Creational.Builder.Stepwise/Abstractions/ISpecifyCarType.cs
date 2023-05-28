using Sebs.Creational.Builder.Stepwise.Models;

namespace Sebs.Creational.Builder.Stepwise.Abstractions
{
    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType carType);
    }
}