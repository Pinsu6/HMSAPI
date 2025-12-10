using HotelManagement.ViewModels.RequestModels;
using HotelManagement.ViewModels.ViewModels;
using System.Threading.Tasks;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IDashboardRepository
    {
        Task<ResponseDto> GetDashboardSummary(DashboardReqDto req);
    }
}
