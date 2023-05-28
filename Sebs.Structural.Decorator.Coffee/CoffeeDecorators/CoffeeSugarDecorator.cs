using Sebs.Structural.Decorator.Coffee.CoffeeDecorators;

namespace Sebs.Structural.Decorator.Coffee
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/14/2023 9:00:15 PM
    /// </summary>
    public class CoffeeSugarDecorator : CoffeeDecorator
    {
        public CoffeeSugarDecorator(ICoffee coffee) 
            : base(coffee)
        {
        }

        // decorate the price of coffee with the cost of the sugar
        public override decimal GetPrice() => _coffee.GetPrice() + 0.25m;  
        
    }
}
