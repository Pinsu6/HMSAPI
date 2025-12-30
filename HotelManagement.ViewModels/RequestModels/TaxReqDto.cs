using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class TaxReqDto : PagingReqDto
    {
        public int? TaxId { get; set; }
        public string? TaxName { get; set; }
        public decimal? TaxRate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
