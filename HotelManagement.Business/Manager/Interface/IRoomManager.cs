using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IRoomManager
    {
        Task<ResponseDto> GetRooms(RoomReqDto req);
        Task<ResponseDto> InsertUpdateRoom(RoomReqDto req);
        Task<ResponseDto> MarkCleanRoom(RoomReqDto req);
    }
}
