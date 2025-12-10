using System.Data;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Data.Contexts;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.ViewModels.ViewModels;

namespace HotelManagement.Data.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly HotelDbContext _dbContext;

        public GuestRepository(HotelDbContext context)
        {
            _dbContext = context;
        }

        public async Task<ResponseDto> GetGuests(GuestReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIGuestGet {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }

        public async Task<ResponseDto> InsertUpdateGuest(GuestReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIGuestInsertUpdate {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }
    }
}
