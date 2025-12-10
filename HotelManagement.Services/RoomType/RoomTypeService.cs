using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.RoomType.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.RoomType
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeManager _manager;

        public RoomTypeService(IRoomTypeManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetRoomTypes(RoomTypeReqDto req)
        {
            return _manager.GetRoomTypes(req);
        }

        public Task<ResponseDto> InsertUpdateRoomType(RoomTypeReqDto req)
        {
            return _manager.InsertUpdateRoomType(req);
        }
    }
}
