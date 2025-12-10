using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IOrderRepository
    {
        Task<ResponseDto> GetOrders(OrderReqDto req);
    }
}
