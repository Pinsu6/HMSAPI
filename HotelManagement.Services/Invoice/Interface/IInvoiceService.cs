using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Invoice.Interface
{
    public interface IInvoiceService
    {
        Task<ResponseDto> GetInvoices(InvoiceReqDto req);
        Task<ResponseDto> InsertUpdateInvoice(InvoiceReqDto req);
    }
}
