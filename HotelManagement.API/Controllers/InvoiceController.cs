using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Invoice.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _service;

        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }

        [HttpPost("getInvoice")]
        public async Task<IActionResult> GetInvoice([FromBody] InvoiceReqDto req)
        {
            return Ok(await _service.GetInvoices(req));
        }

        [HttpPost("AddInvoice")]
        public async Task<IActionResult> AddInvoice([FromBody] InvoiceReqDto req)
        {
            return Ok(await _service.InsertUpdateInvoice(req));
        }
    }
}
