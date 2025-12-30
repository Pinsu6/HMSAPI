using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IFloorManager
    {
        Task<ResponseDto> GetFloors(FloorReqDto req);
        Task<ResponseDto> AddFloor(FloorReqDto req);
        Task<ResponseDto> DeleteFloor(FloorReqDto req);
    }
}
