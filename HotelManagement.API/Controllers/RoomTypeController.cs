using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.RoomType.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _service;

        public RoomTypeController(IRoomTypeService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetRoomTypes([FromBody] RoomTypeReqDto req)
        {
            return Ok(await _service.GetRoomTypes(req));
        }

        [HttpPost("insertupdate")]
        public async Task<IActionResult> InsertUpdateRoomType([FromBody] RoomTypeReqDto req)
        {
            return Ok(await _service.InsertUpdateRoomType(req));
        }

        [HttpPost("deleteRoomType")]
        public async Task<IActionResult> DeleteRoomType([FromBody] RoomTypeReqDto req)
        {
            return Ok(await _service.DeleteRoomType(req));
        }
    }
}
