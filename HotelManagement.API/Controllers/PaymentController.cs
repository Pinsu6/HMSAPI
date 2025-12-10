using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Payment.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _service;

        public PaymentController(IPaymentService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetPayments([FromBody] PaymentReqDto req)
        {
            return Ok(await _service.GetPayments(req));
        }

        [HttpPost("insertupdate")]
        public async Task<IActionResult> InsertUpdatePayment([FromBody] PaymentReqDto req)
        {
            return Ok(await _service.InsertUpdatePayment(req));
        }
    }
}
