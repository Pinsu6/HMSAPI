using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class CurrencyReqDto : PagingReqDto
    {
        public int CurrencyId { get; set; }
        public string? CurrencyCode { get; set; }     // e.g. USD, INR
        public string? CurrencyName { get; set; }     // e.g. US Dollar, Indian Rupee
        public string? Symbol { get; set; }           // $, ₹
        public decimal? ExchangeRate { get; set; }    // For conversion
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
