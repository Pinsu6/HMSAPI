using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;
using System.Threading.Tasks;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IDashboardManager
    {
        Task<ResponseDto> GetDashboardSummary(DashboardReqDto req);
    }
}
