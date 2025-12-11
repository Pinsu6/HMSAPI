using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class AddServicesManager : IAddServicesManager
    {
        private readonly IAddServicesRepository _repo;

        public AddServicesManager(IAddServicesRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetServices(AddServicesReqDto req)
        {
            return _repo.GetServices(req);
        }

        public Task<ResponseDto> InsertUpdateService(AddServicesReqDto req)
        {
            return _repo.InsertUpdateService(req);
        }

        public Task<ResponseDto> DeleteService(AddServicesReqDto req)
        {
            return _repo.DeleteService(req);
        }
    }
}
