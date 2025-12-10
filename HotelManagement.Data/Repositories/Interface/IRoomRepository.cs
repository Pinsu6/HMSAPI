using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IRoomRepository
    {
        Task<ResponseDto> GetRooms(RoomReqDto req);
        Task<ResponseDto> InsertUpdateRoom(RoomReqDto req);
        Task<ResponseDto> MarkCleanRoom(RoomReqDto req);
    }
}
