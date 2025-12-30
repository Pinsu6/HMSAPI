using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Tax.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Tax
{
    public class TaxService : ITaxService
    {
        private readonly ITaxManager _manager;

        public TaxService(ITaxManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetTax(TaxReqDto req)
        {
            return _manager.GetTax(req);
        }

        public Task<ResponseDto> AddTax(TaxReqDto req)
        {
            return _manager.AddTax(req);
        }

        public Task<ResponseDto> DeleteTax(TaxReqDto req)
        {
            return _manager.DeleteTax(req);
        }
    }
}
