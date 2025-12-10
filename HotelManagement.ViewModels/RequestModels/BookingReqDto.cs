using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class BookingReqDto : PagingReqDto
    {
        public int? BookingId { get; set; }
        public int? GuestId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? CheckInTime { get; set; }
        public DateTime? ExpectedCheckOutTime { get; set; }
        public DateTime? ActualCheckOutTime { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public string? Status { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
