using DevFreela.Payment.API.Models;

namespace DevFreela.Payment.API.Services
{
    public interface IPaymentServices
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
    }
}
