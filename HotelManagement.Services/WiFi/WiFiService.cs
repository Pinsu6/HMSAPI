using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.WiFi.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.WiFi
{
    public class WiFiService : IWiFiService
    {
        private readonly IWiFiManager _manager;

        public WiFiService(IWiFiManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> CreateGuest(WiFiReqDto req)
        {
            return _manager.CreateGuest(req);
        }

        public Task<ResponseDto> ExpireGuest(WiFiReqDto req)
        {
            return _manager.ExpireGuest(req);
        }
    }
}
