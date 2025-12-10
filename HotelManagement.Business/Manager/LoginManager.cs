using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class LoginManager : ILoginManager
    {
        private readonly ILoginRepository _repo;

        public LoginManager(ILoginRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> Login(LoginReqDto req)
        {
            return _repo.Login(req);
        }
    }
}
