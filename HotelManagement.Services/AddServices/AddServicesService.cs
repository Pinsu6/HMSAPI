using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.AddServices.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.AddServices
{
    public class AddServicesService : IAddServicesService
    {
        private readonly IAddServicesManager _manager;

        public AddServicesService(IAddServicesManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetServices(AddServicesReqDto req)
        {
            return _manager.GetServices(req);
        }

        public Task<ResponseDto> InsertUpdateService(AddServicesReqDto req)
        {
            return _manager.InsertUpdateService(req);
        }

        public Task<ResponseDto> DeleteService(AddServicesReqDto req)
        {
            return _manager.DeleteService(req);
        }
    }
}
