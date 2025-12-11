using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.Services.Currency.Interface;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _service;

        public CurrencyController(ICurrencyService service)
        {
            _service = service;
        }

        [HttpPost("GetCurrencies")]
        public async Task<IActionResult> GetCurrencies([FromBody] CurrencyReqDto req)
        {
            return Ok(await _service.GetCurrencies(req));
        }

        [HttpPost("InsertUpdateCurrency")]
        public async Task<IActionResult> InsertUpdateCurrency([FromBody] CurrencyReqDto req)
        {
            return Ok(await _service.InsertUpdateCurrency(req));
        }

        [HttpPost("DeleteCurrency")]
        public async Task<IActionResult> DeleteCurrency([FromBody] CurrencyReqDto req)
        {
            return Ok(await _service.DeleteCurrency(req));
        }
    }
}
