using HotelManagement.Services.Dashboard.Interface;
using HotelManagement.ViewModels.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _service;

        public DashboardController(IDashboardService service)
        {
            _service = service;
        }

        [HttpPost("GetDashboardSummary")]
        public async Task<IActionResult> GetDashboardSummary([FromBody] DashboardReqDto req)
        {
            var result = await _service.GetDashboardSummary(req);
            return Ok(result);
        }
    }
}
