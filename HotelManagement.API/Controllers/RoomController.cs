using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Room.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _service;

        public RoomController(IRoomService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetRooms([FromBody] RoomReqDto req)
        {
            return Ok(await _service.GetRooms(req));
        }

        [HttpPost("insertupdate")]
        public async Task<IActionResult> InsertUpdateRoom([FromBody] RoomReqDto req)
        {
            return Ok(await _service.InsertUpdateRoom(req));
        }

        [HttpPost("markclean")]
        public async Task<IActionResult> MarkCleanRoom([FromBody] RoomReqDto req)
        {
            return Ok(await _service.MarkCleanRoom(req));
        }
    }
}
