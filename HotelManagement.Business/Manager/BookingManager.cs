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
        private readonly IWiFiManager _wifiManager;

        public BookingManager(IBookingRepository repo, IWiFiManager wifiManager)
        {
            _repo = repo;
            _wifiManager = wifiManager;
        }

        public Task<ResponseDto> GetBookings(BookingReqDto req)
        {
            return _repo.GetBookings(req);
        }

        public async Task<ResponseDto> InsertUpdateBooking(BookingReqDto req)
        {
            var response = await _repo.InsertUpdateBooking(req);

            // If check-in successful, trigger Wi-Fi creation
            if (response != null && req.Status == "Checked-In")
            {
                // Simple logic to generate Username/Password
                string generatedUsername = "R" + req.RoomId; 
                string generatedPassword = new System.Random().Next(100000, 999999).ToString();

                await _wifiManager.CreateGuest(new WiFiReqDto
                {
                    BookingId = req.BookingId,
                    RoomNumber = req.RoomId?.ToString(),
                    Username = generatedUsername,
                    PasswordHash = generatedPassword,
                    ExpiryTime = req.ExpectedCheckOutTime,
                    Status = "Active"
                });
            }

            return response;
        }

        public async Task<ResponseDto> CheckOutBooking(BookingReqDto req)
        {
            var response = await _repo.CheckOutBooking(req);

            // If check-out successful, trigger Wi-Fi expiration
            if (response != null)
            {
                await _wifiManager.ExpireGuest(new WiFiReqDto
                {
                    BookingId = req.BookingId,
                    RoomNumber = req.RoomId?.ToString()
                });
            }

            return response;
        }
    }
}
