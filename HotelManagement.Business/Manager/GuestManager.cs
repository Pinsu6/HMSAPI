using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class GuestManager : IGuestManager
    {
        private readonly IGuestRepository _repo;

        public GuestManager(IGuestRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetGuests(GuestReqDto req)
        {
            return _repo.GetGuests(req);
        }

        public Task<ResponseDto> InsertUpdateGuest(GuestReqDto req)
        {
            return _repo.InsertUpdateGuest(req);
        }
    }
}
