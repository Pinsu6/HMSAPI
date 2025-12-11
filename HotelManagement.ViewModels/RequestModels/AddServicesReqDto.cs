using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class AddServicesReqDto : PagingReqDto
    {
        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }      // Ex: Laundry, Extra Bed
        public string? Description { get; set; }
        public decimal? Rate { get; set; }            // Price per unit
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
