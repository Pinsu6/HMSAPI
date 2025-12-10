using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface IBookingManager
    {
        Task<ResponseDto> GetBookings(BookingReqDto req);
        Task<ResponseDto> InsertUpdateBooking(BookingReqDto req);
        Task<ResponseDto> CheckOutBooking(BookingReqDto req);
    }
}
