using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class RoomTypeManager : IRoomTypeManager
    {
        private readonly IRoomTypeRepository _repo;

        public RoomTypeManager(IRoomTypeRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetRoomTypes(RoomTypeReqDto req)
        {
            return _repo.GetRoomTypes(req);
        }

        public Task<ResponseDto> InsertUpdateRoomType(RoomTypeReqDto req)
        {
            return _repo.InsertUpdateRoomType(req);
        }

        public Task<ResponseDto> DeleteRoomType(RoomTypeReqDto req)
        {
            return _repo.DeleteRoomType(req);
        }
    }
}
