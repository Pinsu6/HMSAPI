using HotelManagement.Business.Manager.Interface;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;
using System.Threading.Tasks;

namespace HotelManagement.Business.Manager
{
    public class DashboardManager : IDashboardManager
    {
        private readonly IDashboardRepository _repository;

        public DashboardManager(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseDto> GetDashboardSummary(DashboardReqDto req)
        {
            return await _repository.GetDashboardSummary(req);
        }
    }
}
