using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class HotelManager : IHotelManager
    {
        private readonly IHotelRepository _repo;

        public HotelManager(IHotelRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetHotelInformation(HotelReqDto req)
        {
            return _repo.GetHotelInformation(req);
        }

        public Task<ResponseDto> InsertUpdateHotelInformation(HotelReqDto req)
        {
            return _repo.InsertUpdateHotelInformation(req);
        }

        public Task<ResponseDto> DeleteHotelInformation(HotelReqDto req)
        {
            return _repo.DeleteHotelInformation(req);
        }
    }
}
