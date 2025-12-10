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
    public class BookingRepository : IBookingRepository
    {
        #region Declare Variables
        private readonly HotelDbContext _dbContext;
        #endregion

        #region Constructor
        public BookingRepository(HotelDbContext context)
        {
            _dbContext = context;
        }
        #endregion

        #region Methods

        public async Task<ResponseDto> GetBookings(BookingReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIBookingGet {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }

        public async Task<ResponseDto> InsertUpdateBooking(BookingReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIBookingInsertUpdate {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }

        #endregion

        public async Task<ResponseDto> CheckOutBooking(BookingReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIBookingCheckOut {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }
    }
}
