using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.WiFiLog.Interface
{
    public interface IWiFiLogService
    {
        Task<ResponseDto> GetWiFiLogs(WiFiLogReqDto req);
    }
}
