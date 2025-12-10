using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Login.Interface
{
    public interface ILoginService
    {
        Task<ResponseDto> Login(LoginReqDto req);
    }
}
