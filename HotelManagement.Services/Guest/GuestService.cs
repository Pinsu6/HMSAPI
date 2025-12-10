using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Guest.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Guest
{
    public class GuestService : IGuestService
    {
        private readonly IGuestManager _manager;

        public GuestService(IGuestManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetGuests(GuestReqDto req)
        {
            return _manager.GetGuests(req);
        }

        public Task<ResponseDto> InsertUpdateGuest(GuestReqDto req)
        {
            return _manager.InsertUpdateGuest(req);
        }
    }
}
