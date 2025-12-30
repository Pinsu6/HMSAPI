using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class FloorManager : IFloorManager
    {
        private readonly IFloorRepository _repo;

        public FloorManager(IFloorRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetFloors(FloorReqDto req)
        {
            return _repo.GetFloors(req);
        }

        public Task<ResponseDto> AddFloor(FloorReqDto req)
        {
            return _repo.AddFloor(req);
        }

        public Task<ResponseDto> DeleteFloor(FloorReqDto req)
        {
            return _repo.DeleteFloor(req);
        }
    }
}
