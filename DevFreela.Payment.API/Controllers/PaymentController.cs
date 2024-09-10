using DevFreela.Payment.API.Models;
using DevFreela.Payment.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payment.API.Controllers
{
    [Route("api/payments")]
    public class PaymentController : ControllerBase 
    {

        private readonly IPaymentServices _paymentService;

        public PaymentController(IPaymentServices paymentServices)
        {
            _paymentService = paymentServices;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PaymentInfoInputModel paymentModel)
        {
            var result = await _paymentService.Process(paymentModel);

            if (!result)
                return BadRequest();

            return Ok();
        }

    }
}
