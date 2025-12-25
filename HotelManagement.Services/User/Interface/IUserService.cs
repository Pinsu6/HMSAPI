using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.User.Interface
{
    public interface IUserService
    {
        Task<ResponseDto> GetUsers(UserReqDto req);
        Task<ResponseDto> AddUser(UserReqDto req);
    }
}
