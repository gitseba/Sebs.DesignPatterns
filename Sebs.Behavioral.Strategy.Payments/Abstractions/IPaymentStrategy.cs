namespace Sebs.Behavioral.Strategy.Payments.Abstractions
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 11:33:07 AM
    /// </summary>
    public interface IPaymentStrategy
    {
        void ProcessPayment(float amount);
    }
}

