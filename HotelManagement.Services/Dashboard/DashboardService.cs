using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Dashboard.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;
using System.Threading.Tasks;

namespace HotelManagement.Services.Dashboard
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardManager _manager;

        public DashboardService(IDashboardManager manager)
        {
            _manager = manager;
        }

        public async Task<ResponseDto> GetDashboardSummary(DashboardReqDto req)
        {
            return await _manager.GetDashboardSummary(req);
        }
    }
}
