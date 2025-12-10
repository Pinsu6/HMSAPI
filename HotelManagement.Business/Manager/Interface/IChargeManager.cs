using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IChargeManager
    {
        Task<ResponseDto> GetCharges(ChargeReqDto req);
        Task<ResponseDto> InsertUpdateCharge(ChargeReqDto req);
    }
}
