using System.Threading.Tasks;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.ViewModels.ViewModels;

namespace HotelManagement.Services.Hotel.Interface
{
    public interface IHotelService
    {
        Task<ResponseDto> GetHotelInformation(HotelReqDto req);
        Task<ResponseDto> InsertUpdateHotelInformation(HotelReqDto req);
        Task<ResponseDto> DeleteHotelInformation(HotelReqDto req);
    }
}
