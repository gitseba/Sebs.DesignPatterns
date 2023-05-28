namespace Sebs.Structural.Decorator.Coffee
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 12:09:10 PM
    /// </summary>
    public class ConcreteCoffee : ICoffee
    {
        public virtual decimal GetPrice() => 2.00m;  // base concrete coffee price 
    }
}
