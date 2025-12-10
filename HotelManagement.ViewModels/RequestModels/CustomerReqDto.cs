namespace HotelManagement.ViewModels.RequestModels
{
    public class CustomerReqDto : PagingReqDto
    {
        public int? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
    }
}
