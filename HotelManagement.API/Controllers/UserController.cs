using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Services.User.Interface;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetUsers([FromBody] UserReqDto req)
        {
            return Ok(await _service.GetUsers(req));
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] UserReqDto req)
        {
            return Ok(await _service.AddUser(req));
        }
    }
}
