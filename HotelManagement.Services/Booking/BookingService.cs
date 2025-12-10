using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Booking.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Booking
{
    // Actually, let's correct namespace to HotelManagement.Services.Booking
    public class BookingService : IBookingService
    {
        private readonly IBookingManager _manager;

        public BookingService(IBookingManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetBookings(BookingReqDto req)
        {
            return _manager.GetBookings(req);
        }

        public Task<ResponseDto> InsertUpdateBooking(BookingReqDto req)
        {
            return _manager.InsertUpdateBooking(req);
        }

        public Task<ResponseDto> CheckOutBooking(BookingReqDto req)
        {
            return _manager.CheckOutBooking(req);
        }
    }
}
