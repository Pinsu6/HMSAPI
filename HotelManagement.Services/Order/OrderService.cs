using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Order.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderManager _manager;

        public OrderService(IOrderManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetOrders(OrderReqDto req)
        {
            return _manager.GetOrders(req);
        }
    }
}
