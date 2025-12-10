namespace HotelManagement.ViewModels.RequestModels
{
    public class GuestReqDto : PagingReqDto
    {
        public int? GuestId { get; set; }
        public string? FullName { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? IdType { get; set; }
        public string? IdNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
