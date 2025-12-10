using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Charge.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChargeController : ControllerBase
    {
        private readonly IChargeService _service;

        public ChargeController(IChargeService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetCharges([FromBody] ChargeReqDto req)
        {
            return Ok(await _service.GetCharges(req));
        }

        [HttpPost("insertupdate")]
        public async Task<IActionResult> InsertUpdateCharge([FromBody] ChargeReqDto req)
        {
            return Ok(await _service.InsertUpdateCharge(req));
        }
    }
}
