using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class InvoiceManager : IInvoiceManager
    {
        private readonly IInvoiceRepository _repo;

        public InvoiceManager(IInvoiceRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetInvoices(InvoiceReqDto req)
        {
            return _repo.GetInvoices(req);
        }

        public Task<ResponseDto> InsertUpdateInvoice(InvoiceReqDto req)
        {
            return _repo.InsertUpdateInvoice(req);
        }
    }
}
