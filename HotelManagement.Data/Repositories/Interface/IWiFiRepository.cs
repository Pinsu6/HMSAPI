using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IWiFiRepository
    {
        Task<ResponseDto> CreateGuest(WiFiReqDto req);
        Task<ResponseDto> ExpireGuest(WiFiReqDto req);
    }
}
