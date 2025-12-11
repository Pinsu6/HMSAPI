using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class CurrencyManager : ICurrencyManager
    {
        private readonly ICurrencyRepository _repo;

        public CurrencyManager(ICurrencyRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetCurrencies(CurrencyReqDto req)
        {
            return _repo.GetCurrencies(req);
        }

        public Task<ResponseDto> InsertUpdateCurrency(CurrencyReqDto req)
        {
            return _repo.InsertUpdateCurrency(req);
        }

        public Task<ResponseDto> DeleteCurrency(CurrencyReqDto req)
        {
            return _repo.DeleteCurrency(req);
        }
    }
}
