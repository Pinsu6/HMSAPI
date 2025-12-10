using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class ChargeReqDto : PagingReqDto
    {
        public int? ChargeId { get; set; }
        public int? BookingId { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
    }
}
