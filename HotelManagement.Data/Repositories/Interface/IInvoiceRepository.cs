using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IInvoiceRepository
    {
        Task<ResponseDto> GetInvoices(InvoiceReqDto req);
        Task<ResponseDto> InsertUpdateInvoice(InvoiceReqDto req);
    }
}
