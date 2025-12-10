using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;
using System.Threading.Tasks;

namespace HotelManagement.Services.Dashboard.Interface
{
    public interface IDashboardService
    {
        Task<ResponseDto> GetDashboardSummary(DashboardReqDto req);
    }
}
