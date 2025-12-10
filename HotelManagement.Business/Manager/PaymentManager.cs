using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class PaymentManager : IPaymentManager
    {
        private readonly IPaymentRepository _repo;

        public PaymentManager(IPaymentRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetPayments(PaymentReqDto req)
        {
            return _repo.GetPayments(req);
        }

        public Task<ResponseDto> InsertUpdatePayment(PaymentReqDto req)
        {
            return _repo.InsertUpdatePayment(req);
        }
    }
}
