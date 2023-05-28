using Sebs.Behavioral.Strategy.Payments.Strategies;

namespace Sebs.Behavioral.Strategy.Payments
{
    /// <summary>
    /// The strategy pattern is helpful in eliminating a growing number of if and switch cases. 
    /// By using interfaces or, in simpler cases, plain functions (i.e. static methods), 
    /// we can introduce a more flexible, maintainable and predictable way of dealing with choosing specific algorithms or paths of logic.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //Use the credit card payment strategy
            PaymentProcessorContext paymentProcessor = new PaymentProcessorContext(new CreditCardPaymentStrategy());
            paymentProcessor.ProcessPayment(100.50f);

            //Use the paypal payment strategy
            paymentProcessor = new PaymentProcessorContext(new PayPalPaymentStrategy());
            paymentProcessor.ProcessPayment(75.20f);


            Console.ReadLine();
        }
    }
}