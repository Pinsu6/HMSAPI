using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Room.Interface
{
    public interface IRoomService
    {
        Task<ResponseDto> GetRooms(RoomReqDto req);
        Task<ResponseDto> InsertUpdateRoom(RoomReqDto req);
        Task<ResponseDto> MarkCleanRoom(RoomReqDto req);
    }
}
