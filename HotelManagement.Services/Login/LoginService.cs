using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Login.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly ILoginManager _manager;

        public LoginService(ILoginManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> Login(LoginReqDto req)
        {
            return _manager.Login(req);
        }
    }
}
