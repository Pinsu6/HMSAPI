namespace HotelManagement.ViewModels.RequestModels
{
    public class RoomTypeReqDto : PagingReqDto
    {
        public int? TypeId { get; set; }
        public string? Name { get; set; }
        public decimal? BaseRate { get; set; }
        public int? MaxGuests { get; set; }
        public string? Amenities { get; set; }
    }
}
