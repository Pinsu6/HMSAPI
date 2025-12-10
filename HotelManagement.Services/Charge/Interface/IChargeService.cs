using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Charge.Interface
{
    public interface IChargeService
    {
        Task<ResponseDto> GetCharges(ChargeReqDto req);
        Task<ResponseDto> InsertUpdateCharge(ChargeReqDto req);
    }
}
