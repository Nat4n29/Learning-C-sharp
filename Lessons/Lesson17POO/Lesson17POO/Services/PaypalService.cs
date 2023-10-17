namespace Lesson17POO.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

        public double paymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
