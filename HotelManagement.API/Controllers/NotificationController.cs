using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.Services.Notification.Interface;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;

        public NotificationController(INotificationService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetNotifications([FromBody] NotificationReqDto req)
        {
            return Ok(await _service.GetNotifications(req));
        }

        [HttpPost("markread")]
        public async Task<IActionResult> MarkRead([FromBody] NotificationReqDto req)
        {
            return Ok(await _service.MarkRead(req));
        }
    }
}
