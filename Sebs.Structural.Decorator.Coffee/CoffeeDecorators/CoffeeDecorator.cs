namespace Sebs.Structural.Decorator.Coffee.CoffeeDecorators
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 12:06:59 PM
    /// </summary>
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual decimal GetPrice() => _coffee.GetPrice(); 
    }
}
