using Lesson17POO.Entities;

namespace Lesson17POO.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
            double monthValue = contract.TotalValue / months;
            
            for(int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateValue = monthValue + _onlinePaymentService.interest(monthValue, i);
                double fullValue = updateValue + _onlinePaymentService.paymentFee(updateValue);

                contract.AddInstallment(new Installment(date, fullValue));
            }
        }
    }
}
