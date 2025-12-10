using HotelManagement.Data.Contexts;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace HotelManagement.Data.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly HotelDbContext _dbContext;

        public DashboardRepository(HotelDbContext context)
        {
            _dbContext = context;
        }

        public async Task<ResponseDto> GetDashboardSummary(DashboardReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = System.Text.Json.JsonSerializer.Serialize(req);

            Microsoft.Data.SqlClient.SqlParameter pJson = new Microsoft.Data.SqlClient.SqlParameter("@pJsonData", System.Data.SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIDashboardSummary @pJsonData", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response ?? new ResponseDto();
        }
    }
}
