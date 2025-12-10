using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IGuestRepository
    {
        Task<ResponseDto> GetGuests(GuestReqDto req);
        Task<ResponseDto> InsertUpdateGuest(GuestReqDto req);
    }
}
