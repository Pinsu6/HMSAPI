using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class TaxManager : ITaxManager
    {
        private readonly ITaxRepository _repo;

        public TaxManager(ITaxRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetTax(TaxReqDto req)
        {
            return _repo.GetTax(req);
        }

        public Task<ResponseDto> AddTax(TaxReqDto req)
        {
            return _repo.AddTax(req);
        }

        public Task<ResponseDto> DeleteTax(TaxReqDto req)
        {
            return _repo.DeleteTax(req);
        }
    }
}
