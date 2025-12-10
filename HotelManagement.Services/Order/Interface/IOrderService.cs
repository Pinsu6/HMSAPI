using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Order.Interface
{
    public interface IOrderService
    {
        Task<ResponseDto> GetOrders(OrderReqDto req);
    }
}
