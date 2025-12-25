using System.Threading.Tasks;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.ViewModels.ViewModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IHotelManager
    {
        Task<ResponseDto> GetHotelInformation(HotelReqDto req);
        Task<ResponseDto> InsertUpdateHotelInformation(HotelReqDto req);
        Task<ResponseDto> DeleteHotelInformation(HotelReqDto req);
    }
}
