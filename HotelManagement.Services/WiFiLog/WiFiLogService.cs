using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.WiFiLog.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.WiFiLog
{
    public class WiFiLogService : IWiFiLogService
    {
        private readonly IWiFiLogManager _manager;

        public WiFiLogService(IWiFiLogManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetWiFiLogs(WiFiLogReqDto req)
        {
            return _manager.GetWiFiLogs(req);
        }
    }
}
