using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _repo;

        public UserManager(IUserRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetUsers(UserReqDto req)
        {
            return _repo.GetUsers(req);
        }
    }
}
