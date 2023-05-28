using Sebs.Structural.Decorator.Coffee.CoffeeDecorators;

namespace Sebs.Structural.Decorator.Coffee
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/14/2023 8:59:46 PM
    /// </summary>
    public class CoffeeMilkDecorator : CoffeeDecorator
    {
        public CoffeeMilkDecorator(ICoffee coffee)
            : base(coffee)
        {
        }

        // decorate the price of coffee with the cost of milk
        public override decimal GetPrice() => _coffee.GetPrice() + 0.50m;

    }
}
