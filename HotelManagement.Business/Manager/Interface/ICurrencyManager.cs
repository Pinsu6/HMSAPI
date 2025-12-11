using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface ICurrencyManager
    {
        Task<ResponseDto> GetCurrencies(CurrencyReqDto req);
        Task<ResponseDto> InsertUpdateCurrency(CurrencyReqDto req);
        Task<ResponseDto> DeleteCurrency(CurrencyReqDto req);
    }
}
