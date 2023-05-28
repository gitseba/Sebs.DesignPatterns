namespace Sebs.Structural.Decorator.Coffee
{
    /// <summary>
    /// The Decorator pattern is a structural design pattern that allows you to add additional behavior 
    /// or responsibilities to an object dynamically without changing its original structure or modifying its code. 
    /// It follows the principle of composition over inheritance, 
    /// providing a flexible alternative to subclassing for extending an object's functionality.
    /// 
    ///The key participants in the Decorator pattern are:
    ///
    /// Component:          This represents the base interface or abstract class that defines the common interface 
    ///                     for both the original object and its decorators.
    ///
    /// Concrete Component: This is the original object to which additional functionality will be added. It implements the Component interface.
    ///
    /// Decorator:          This is an abstract class that also implements the Component interface.
    ///                     It acts as a base class for concrete decorators and holds a reference to the Component object. The decorator has the same interface as the Component, allowing it to be used interchangeably.
    ///
    /// Concrete Decorator: These are concrete subclasses of the Decorator class. 
    ///                     They add specific behaviors or responsibilities to the original object by extending the functionality of the Component.
    ///                     Each concrete decorator overrides the methods of the Component and adds its own behavior 
    ///                     before or after delegating to the wrapped Component object.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Decorator pattern! \n");

            ICoffee coffee = new ConcreteCoffee();  // create a basic coffee object
            Console.WriteLine($"Coffee: {coffee.GetPrice()}");

            var milkCoffee = new CoffeeMilkDecorator(coffee);  // wrap the coffee in milk
            Console.WriteLine($"Coffee + Milk: {milkCoffee.GetPrice()}");

            var sugarMilkCoffee = new CoffeeSugarDecorator(new CoffeeMilkDecorator(coffee));  // wrap the coffee in milk
            Console.WriteLine($"Coffee + Milk + Sugar: {sugarMilkCoffee.GetPrice()}");

            Console.ReadLine();
        }
    }
}