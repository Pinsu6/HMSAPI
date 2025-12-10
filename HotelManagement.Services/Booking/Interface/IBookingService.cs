using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Booking.Interface
{
    // Note: Assuming "Room" folder is for "RoomService" but generalized services might need their own folders.
    // However, adhering to user's "HotelManagement.Services -> Room" structure implies organization by feature.
    // I will create a "Booking" folder for BookingService to keep it clean.
    public interface IBookingService
    {
        Task<ResponseDto> GetBookings(BookingReqDto req);
        Task<ResponseDto> InsertUpdateBooking(BookingReqDto req);
        Task<ResponseDto> CheckOutBooking(BookingReqDto req);
    }
}
