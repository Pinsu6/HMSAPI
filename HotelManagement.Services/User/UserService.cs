using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.User.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserManager _manager;

        public UserService(IUserManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetUsers(UserReqDto req)
        {
            return _manager.GetUsers(req);
        }
    }
}
