using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class ChargeManager : IChargeManager
    {
        private readonly IChargeRepository _repo;

        public ChargeManager(IChargeRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetCharges(ChargeReqDto req)
        {
            return _repo.GetCharges(req);
        }

        public Task<ResponseDto> InsertUpdateCharge(ChargeReqDto req)
        {
            return _repo.InsertUpdateCharge(req);
        }
    }
}
