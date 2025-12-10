using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class WiFiLogManager : IWiFiLogManager
    {
        private readonly IWiFiLogRepository _repo;

        public WiFiLogManager(IWiFiLogRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetWiFiLogs(WiFiLogReqDto req)
        {
            return _repo.GetWiFiLogs(req);
        }
    }
}
