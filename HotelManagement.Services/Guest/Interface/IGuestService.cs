using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Guest.Interface
{
    public interface IGuestService
    {
        Task<ResponseDto> GetGuests(GuestReqDto req);
        Task<ResponseDto> InsertUpdateGuest(GuestReqDto req);
    }
}
