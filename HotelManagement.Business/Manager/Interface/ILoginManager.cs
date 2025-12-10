using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface ILoginManager
    {
        Task<ResponseDto> Login(LoginReqDto req);
    }
}
