using DevFreela.Payment.API.Models;

namespace DevFreela.Payment.API.Services
{
    public class PaymentService : IPaymentServices
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            return Task.FromResult(true);
        }
    }
}
