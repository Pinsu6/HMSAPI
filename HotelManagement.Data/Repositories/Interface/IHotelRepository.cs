using System.Threading.Tasks;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.ViewModels.ViewModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IHotelRepository
    {
        Task<ResponseDto> GetHotelInformation(HotelReqDto req);
        Task<ResponseDto> InsertUpdateHotelInformation(HotelReqDto req);
        Task<ResponseDto> DeleteHotelInformation(HotelReqDto req);
    }
}
