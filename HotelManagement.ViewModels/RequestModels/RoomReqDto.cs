namespace HotelManagement.ViewModels.RequestModels
{
    public class RoomReqDto : PagingReqDto
    {
        public int? RoomId { get; set; }
        public string? RoomNumber { get; set; }

        public int? FloorId { get; set; }
        public int? RoomTypeId { get; set; }
        public decimal? Price { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
    }
}
