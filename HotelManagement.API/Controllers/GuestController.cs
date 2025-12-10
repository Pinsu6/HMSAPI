using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.Guest.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _service;

        public GuestController(IGuestService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetGuests([FromBody] GuestReqDto req)
        {
            return Ok(await _service.GetGuests(req));
        }

        [HttpPost("insertupdate")]
        public async Task<IActionResult> InsertUpdateGuest([FromBody] GuestReqDto req)
        {
            return Ok(await _service.InsertUpdateGuest(req));
        }
    }
}
