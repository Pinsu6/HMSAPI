using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Payment.Interface
{
    public interface IPaymentService
    {
        Task<ResponseDto> GetPayments(PaymentReqDto req);
        Task<ResponseDto> InsertUpdatePayment(PaymentReqDto req);
    }
}
