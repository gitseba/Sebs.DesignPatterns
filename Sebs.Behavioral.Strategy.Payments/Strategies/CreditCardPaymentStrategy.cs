using Sebs.Behavioral.Strategy.Payments.Abstractions;

namespace Sebs.Behavioral.Strategy.Payments.Strategies
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 11:34:12 AM
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}$");
            // Code for processing credit card payment
        }
    }
}
