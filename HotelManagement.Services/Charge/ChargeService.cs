using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Charge.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Charge
{
    public class ChargeService : IChargeService
    {
        private readonly IChargeManager _manager;

        public ChargeService(IChargeManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetCharges(ChargeReqDto req)
        {
            return _manager.GetCharges(req);
        }

        public Task<ResponseDto> InsertUpdateCharge(ChargeReqDto req)
        {
            return _manager.InsertUpdateCharge(req);
        }
    }
}
