using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface IBookingRepository
    {
        Task<ResponseDto> GetBookings(BookingReqDto req);
        Task<ResponseDto> InsertUpdateBooking(BookingReqDto req);
        Task<ResponseDto> CheckOutBooking(BookingReqDto req);
    }
}
