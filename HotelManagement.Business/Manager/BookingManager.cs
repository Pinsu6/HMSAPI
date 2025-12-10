using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class BookingManager : IBookingManager
    {
        private readonly IBookingRepository _repo;

        public BookingManager(IBookingRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetBookings(BookingReqDto req)
        {
            return _repo.GetBookings(req);
        }

        public Task<ResponseDto> InsertUpdateBooking(BookingReqDto req)
        {
            return _repo.InsertUpdateBooking(req);
        }

        public Task<ResponseDto> CheckOutBooking(BookingReqDto req)
        {
            return _repo.CheckOutBooking(req);
        }
    }
}
