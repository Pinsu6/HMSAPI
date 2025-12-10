using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepository _repo;

        public CustomerManager(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetCustomers(CustomerReqDto req)
        {
            return _repo.GetCustomers(req);
        }
    }
}
