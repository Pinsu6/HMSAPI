using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Customer.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerManager _manager;

        public CustomerService(ICustomerManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetCustomers(CustomerReqDto req)
        {
            return _manager.GetCustomers(req);
        }
    }
}
