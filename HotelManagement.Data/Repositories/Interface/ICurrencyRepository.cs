using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface ICurrencyRepository
    {
        Task<ResponseDto> GetCurrencies(CurrencyReqDto req);
        Task<ResponseDto> InsertUpdateCurrency(CurrencyReqDto req);
        Task<ResponseDto> DeleteCurrency(CurrencyReqDto req);
    }
}
