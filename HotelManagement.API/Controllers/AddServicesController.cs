using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.Services.AddServices.Interface;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddServicesController : ControllerBase
    {
        private readonly IAddServicesService _service;

        public AddServicesController(IAddServicesService service)
        {
            _service = service;
        }

        [HttpPost("GetServices")]
        public async Task<IActionResult> GetServices([FromBody] AddServicesReqDto req)
        {
            return Ok(await _service.GetServices(req));
        }

        [HttpPost("InsertUpdateService")]
        public async Task<IActionResult> InsertUpdateService([FromBody] AddServicesReqDto req)
        {
            return Ok(await _service.InsertUpdateService(req));
        }

        [HttpPost("DeleteService")]
        public async Task<IActionResult> DeleteService([FromBody] AddServicesReqDto req)
        {
            return Ok(await _service.DeleteService(req));
        }
    }
}
