using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Floor.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Floor
{
    public class FloorService : IFloorService
    {
        private readonly IFloorManager _manager;

        public FloorService(IFloorManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetFloors(FloorReqDto req)
        {
            return _manager.GetFloors(req);
        }

        public Task<ResponseDto> AddFloor(FloorReqDto req)
        {
            return _manager.AddFloor(req);
        }

        public Task<ResponseDto> DeleteFloor(FloorReqDto req)
        {
            return _manager.DeleteFloor(req);
        }
    }
}
