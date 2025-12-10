using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<ResponseDto> GetUsers(UserReqDto req);
    }
}
