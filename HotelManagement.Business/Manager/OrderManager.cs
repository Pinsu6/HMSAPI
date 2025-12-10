using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderRepository _repo;

        public OrderManager(IOrderRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetOrders(OrderReqDto req)
        {
            return _repo.GetOrders(req);
        }
    }
}
