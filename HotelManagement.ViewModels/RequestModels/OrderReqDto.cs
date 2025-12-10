using System;

namespace HotelManagement.ViewModels.RequestModels
{
    public class OrderReqDto : PagingReqDto
    {
        public int? OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
    }
}
