using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class RoomManager : IRoomManager
    {
        private readonly IRoomRepository _repo;

        public RoomManager(IRoomRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetRooms(RoomReqDto req)
        {
            return _repo.GetRooms(req);
        }

        public Task<ResponseDto> InsertUpdateRoom(RoomReqDto req)
        {
            return _repo.InsertUpdateRoom(req);
        }

        public Task<ResponseDto> MarkCleanRoom(RoomReqDto req)
        {
            return _repo.MarkCleanRoom(req);
        }
    }
}
