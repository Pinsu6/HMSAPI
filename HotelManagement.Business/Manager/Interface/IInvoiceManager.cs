using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IInvoiceManager
    {
        Task<ResponseDto> GetInvoices(InvoiceReqDto req);
        Task<ResponseDto> InsertUpdateInvoice(InvoiceReqDto req);
    }
}
