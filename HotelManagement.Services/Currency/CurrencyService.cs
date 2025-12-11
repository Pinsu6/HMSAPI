using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Currency.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Currency
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyManager _manager;

        public CurrencyService(ICurrencyManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetCurrencies(CurrencyReqDto req)
        {
            return _manager.GetCurrencies(req);
        }

        public Task<ResponseDto> InsertUpdateCurrency(CurrencyReqDto req)
        {
            return _manager.InsertUpdateCurrency(req);
        }

        public Task<ResponseDto> DeleteCurrency(CurrencyReqDto req)
        {
            return _manager.DeleteCurrency(req);
        }
    }
}
