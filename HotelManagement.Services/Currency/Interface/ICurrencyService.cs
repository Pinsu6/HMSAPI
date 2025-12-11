using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Currency.Interface
{
    public interface ICurrencyService
    {
        Task<ResponseDto> GetCurrencies(CurrencyReqDto req);
        Task<ResponseDto> InsertUpdateCurrency(CurrencyReqDto req);
        Task<ResponseDto> DeleteCurrency(CurrencyReqDto req);
    }
}
