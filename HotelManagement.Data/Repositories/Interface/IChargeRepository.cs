using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IChargeRepository
    {
        Task<ResponseDto> GetCharges(ChargeReqDto req);
        Task<ResponseDto> InsertUpdateCharge(ChargeReqDto req);
    }
}
