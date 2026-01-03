using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class WiFiReqDto
    {
        public int? WifiUserId { get; set; }
        public int? BookingId { get; set; }
        public string? RoomNumber { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime? ExpiryTime { get; set; }
        public string? Status { get; set; }
    }
}
