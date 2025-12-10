using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HotelManagement.ViewModels.RequestModels;

// Adjusting namespace for Service Interface
using HotelManagement.Services.Booking.Interface; // Assuming I fixed the namespace in previous step file path

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingController(IBookingService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetBookings([FromBody] BookingReqDto req)
        {
            return Ok(await _service.GetBookings(req));
        }

        [HttpPost("insertupdate")]
        public async Task<IActionResult> InsertUpdateBooking([FromBody] BookingReqDto req)
        {
            return Ok(await _service.InsertUpdateBooking(req));
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> CheckOutBooking([FromBody] BookingReqDto req)
        {
            return Ok(await _service.CheckOutBooking(req));
        }
    }
}
