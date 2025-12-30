using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IRoomTypeRepository
    {
        Task<ResponseDto> GetRoomTypes(RoomTypeReqDto req);
        Task<ResponseDto> InsertUpdateRoomType(RoomTypeReqDto req);
        Task<ResponseDto> DeleteRoomType(RoomTypeReqDto req);
    }
}
