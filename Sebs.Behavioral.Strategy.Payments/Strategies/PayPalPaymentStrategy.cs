using Sebs.Behavioral.Strategy.Payments.Abstractions;

namespace Sebs.Behavioral.Strategy.Payments.Strategies
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 11:35:29 AM
    /// </summary>
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(float amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}$");
            // Code for processing PayPal payment
        }
    }
}
