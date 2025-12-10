using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.WiFiLog.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WiFiLogController : ControllerBase
    {
        private readonly IWiFiLogService _service;

        public WiFiLogController(IWiFiLogService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetWiFiLogs([FromBody] WiFiLogReqDto req)
        {
            return Ok(await _service.GetWiFiLogs(req));
        }
    }
}
