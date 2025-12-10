using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class PaymentReqDto : PagingReqDto
    {
        public int? PaymentId { get; set; }
        public int? BookingId { get; set; }
        public decimal? Amount { get; set; }
        public string? Mode { get; set; }
        public DateTime? Date { get; set; }
    }
}
