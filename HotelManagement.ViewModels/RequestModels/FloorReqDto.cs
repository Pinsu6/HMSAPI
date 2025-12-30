using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class FloorReqDto : PagingReqDto
    {
        public int? FloorId { get; set; }
        public string? FloorName { get; set; }
        public int? FloorNumber { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
