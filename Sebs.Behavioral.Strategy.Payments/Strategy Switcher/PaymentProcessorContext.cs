using Sebs.Behavioral.Strategy.Payments.Abstractions;

namespace Sebs.Behavioral.Strategy.Payments
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 11:36:58 AM
    /// </summary>
    public class PaymentProcessorContext
    {
        private IPaymentStrategy paymentStrategy;

        public PaymentProcessorContext(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(float amount)
        {
            paymentStrategy.ProcessPayment(amount);
        }
    }
}
