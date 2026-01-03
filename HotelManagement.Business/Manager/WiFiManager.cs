using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class WiFiManager : IWiFiManager
    {
        private readonly IWiFiRepository _repo;

        public WiFiManager(IWiFiRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> CreateGuest(WiFiReqDto req)
        {
            return _repo.CreateGuest(req);
        }

        public Task<ResponseDto> ExpireGuest(WiFiReqDto req)
        {
            return _repo.ExpireGuest(req);
        }
    }
}
