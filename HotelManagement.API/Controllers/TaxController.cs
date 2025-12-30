using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Tax.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxController : ControllerBase
    {
        private readonly ITaxService _service;

        public TaxController(ITaxService service)
        {
            _service = service;
        }

        [HttpPost("getTax")]
        public async Task<IActionResult> GetTax([FromBody] TaxReqDto req)
        {
            return Ok(await _service.GetTax(req));
        }

        [HttpPost("addTax")]
        public async Task<IActionResult> AddTax([FromBody] TaxReqDto req)
        {
            return Ok(await _service.AddTax(req));
        }

        [HttpPost("deleteTax")]
        public async Task<IActionResult> DeleteTax([FromBody] TaxReqDto req)
        {
            return Ok(await _service.DeleteTax(req));
        }
    }
}
