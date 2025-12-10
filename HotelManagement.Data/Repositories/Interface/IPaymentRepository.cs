using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IPaymentRepository
    {
        Task<ResponseDto> GetPayments(PaymentReqDto req);
        Task<ResponseDto> InsertUpdatePayment(PaymentReqDto req);
    }
}
