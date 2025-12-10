using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IGuestManager
    {
        Task<ResponseDto> GetGuests(GuestReqDto req);
        Task<ResponseDto> InsertUpdateGuest(GuestReqDto req);
    }
}
