using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class WiFiLogReqDto : PagingReqDto
    {
        public int? LogId { get; set; }
        public int? BookingId { get; set; }
        public string? RoomNumber { get; set; }
        public string? ApiAction { get; set; }
        public string? Status { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
