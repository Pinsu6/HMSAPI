using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IWiFiManager
    {
        Task<ResponseDto> CreateGuest(WiFiReqDto req);
        Task<ResponseDto> ExpireGuest(WiFiReqDto req);
    }
}
