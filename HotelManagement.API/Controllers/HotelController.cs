using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.Services.Hotel.Interface;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _service;

        public HotelController(IHotelService service)
        {
            _service = service;
        }

        [HttpPost("GetHotelInformation")]
        public async Task<IActionResult> GetHotelInformation([FromBody] HotelReqDto req)
        {
            return Ok(await _service.GetHotelInformation(req));
        }

        [HttpPost("InsertUpdateHotelInformation")]
        public async Task<IActionResult> InsertUpdateHotelInformation([FromBody] HotelReqDto req)
        {
            return Ok(await _service.InsertUpdateHotelInformation(req));
        }

        [HttpPost("DeleteHotelInformation")]
        public async Task<IActionResult> DeleteHotelInformation([FromBody] HotelReqDto req)
        {
            return Ok(await _service.DeleteHotelInformation(req));
        }
    }
}
