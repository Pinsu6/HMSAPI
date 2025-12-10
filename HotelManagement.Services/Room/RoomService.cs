using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Room.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomManager _manager;

        public RoomService(IRoomManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetRooms(RoomReqDto req)
        {
            return _manager.GetRooms(req);
        }

        public Task<ResponseDto> InsertUpdateRoom(RoomReqDto req)
        {
            return _manager.InsertUpdateRoom(req);
        }

        public Task<ResponseDto> MarkCleanRoom(RoomReqDto req)
        {
            return _manager.MarkCleanRoom(req);
        }
    }
}
