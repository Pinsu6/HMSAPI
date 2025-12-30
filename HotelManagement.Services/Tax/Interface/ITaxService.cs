using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Tax.Interface
{
    public interface ITaxService
    {
        Task<ResponseDto> GetTax(TaxReqDto req);
        Task<ResponseDto> AddTax(TaxReqDto req);
        Task<ResponseDto> DeleteTax(TaxReqDto req);
    }
}
