using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IFloorRepository
    {
        Task<ResponseDto> GetFloors(FloorReqDto req);
        Task<ResponseDto> AddFloor(FloorReqDto req);
        Task<ResponseDto> DeleteFloor(FloorReqDto req);
    }
}
