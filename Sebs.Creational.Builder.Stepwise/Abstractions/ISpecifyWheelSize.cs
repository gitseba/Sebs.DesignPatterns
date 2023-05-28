namespace Sebs.Creational.Builder.Stepwise.Abstractions
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int size);
    }
}