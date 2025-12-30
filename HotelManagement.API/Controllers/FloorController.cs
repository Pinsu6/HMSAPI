using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Floor.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FloorController : ControllerBase
    {
        private readonly IFloorService _service;

        public FloorController(IFloorService service)
        {
            _service = service;
        }

        [HttpPost("getFloor")]
        public async Task<IActionResult> GetFloors([FromBody] FloorReqDto req)
        {
            return Ok(await _service.GetFloors(req));
        }

        [HttpPost("addFloor")]
        public async Task<IActionResult> AddFloor([FromBody] FloorReqDto req)
        {
            return Ok(await _service.AddFloor(req));
        }

        [HttpPost("deleteFloor")]
        public async Task<IActionResult> DeleteFloor([FromBody] FloorReqDto req)
        {
            return Ok(await _service.DeleteFloor(req));
        }
    }
}
