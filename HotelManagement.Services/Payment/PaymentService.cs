using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Payment.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Payment
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentManager _manager;

        public PaymentService(IPaymentManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetPayments(PaymentReqDto req)
        {
            return _manager.GetPayments(req);
        }

        public Task<ResponseDto> InsertUpdatePayment(PaymentReqDto req)
        {
            return _manager.InsertUpdatePayment(req);
        }
    }
}
