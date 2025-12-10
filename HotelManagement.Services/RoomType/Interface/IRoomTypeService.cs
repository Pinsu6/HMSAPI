using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.RoomType.Interface
{
    public interface IRoomTypeService
    {
        Task<ResponseDto> GetRoomTypes(RoomTypeReqDto req);
        Task<ResponseDto> InsertUpdateRoomType(RoomTypeReqDto req);
    }
}
