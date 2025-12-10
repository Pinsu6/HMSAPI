using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Customer.Interface
{
    public interface ICustomerService
    {
        Task<ResponseDto> GetCustomers(CustomerReqDto req);
    }
}
