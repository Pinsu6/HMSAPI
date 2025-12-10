using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IPaymentManager
    {
        Task<ResponseDto> GetPayments(PaymentReqDto req);
        Task<ResponseDto> InsertUpdatePayment(PaymentReqDto req);
    }
}
