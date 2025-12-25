using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class HotelReqDto : PagingReqDto
    {
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; }
        public string? Address { get; set; }
        public string? GSTIN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateCreate { get; set; }
    }
}
