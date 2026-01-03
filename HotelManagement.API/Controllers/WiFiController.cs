using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.WiFi.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WiFiController : ControllerBase
    {
        private readonly IWiFiService _service;

        public WiFiController(IWiFiService service)
        {
            _service = service;
        }

        [HttpPost("create-guest")]
        public async Task<IActionResult> CreateGuest([FromBody] WiFiReqDto req)
        {
            return Ok(await _service.CreateGuest(req));
        }

        [HttpPost("expire-guest")]
        public async Task<IActionResult> ExpireGuest([FromBody] WiFiReqDto req)
        {
            return Ok(await _service.ExpireGuest(req));
        }
    }
}
