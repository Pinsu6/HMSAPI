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
    public class HotelRepository : IHotelRepository
    {
        #region Declare Variables
        private readonly HotelDbContext _dbContext;
        #endregion

        #region Constructor
        public HotelRepository(HotelDbContext context)
        {
            _dbContext = context;
        }
        #endregion

        #region Methods

        public async Task<ResponseDto> GetHotelInformation(HotelReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIHotelInformationGet {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }

        public async Task<ResponseDto> InsertUpdateHotelInformation(HotelReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIHotelInformationInsertUpdate {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }

        public async Task<ResponseDto> DeleteHotelInformation(HotelReqDto req)
        {
            ResponseDto response = new ResponseDto();
            var jsonString = JsonSerializer.Serialize(req);

            SqlParameter pJson = new SqlParameter("@pJsonString", SqlDbType.NVarChar)
            {
                Size = int.MaxValue,
                Value = jsonString
            };

            response = (await _dbContext.ResponseDto
                .FromSqlRaw<ResponseDto>("EXEC APIHotelInformationDelete {0}", pJson)
                .ToListAsync())
                .FirstOrDefault();

            return response;
        }

        #endregion
    }
}
