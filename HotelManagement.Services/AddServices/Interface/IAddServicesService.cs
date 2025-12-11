using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.AddServices.Interface
{
    public interface IAddServicesService
    {
        Task<ResponseDto> GetServices(AddServicesReqDto req);
        Task<ResponseDto> InsertUpdateService(AddServicesReqDto req);
        Task<ResponseDto> DeleteService(AddServicesReqDto req);
    }
}
