using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.WiFi.Interface
{
    public interface IWiFiService
    {
        Task<ResponseDto> CreateGuest(WiFiReqDto req);
        Task<ResponseDto> ExpireGuest(WiFiReqDto req);
    }
}
