using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface ITaxRepository
    {
        Task<ResponseDto> GetTax(TaxReqDto req);
        Task<ResponseDto> AddTax(TaxReqDto req);
        Task<ResponseDto> DeleteTax(TaxReqDto req);
    }
}
