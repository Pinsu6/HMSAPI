using System;
using System.Collections.Generic;

namespace HotelManagement.ViewModels.RequestModels
{
    public class InvoiceReqDto : PagingReqDto
    {
        public int? InvoiceId { get; set; }
        public int? BookingId { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? PdfPath { get; set; }
        public DateTime? CreatedOn { get; set; }
        
        // Guest Information
        public string? GuestName { get; set; }
        public string? GuestMobile { get; set; }
        public string? GuestEmail { get; set; }
        public string? IdProofType { get; set; }
        public string? IdProofNumber { get; set; }
        
        // Room Information
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        
        // Stay Details
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public int? TotalNights { get; set; }
        
        // Charges
        public decimal? RoomRate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? GrandTotal { get; set; }
        
        // Payment
        public string? PaymentStatus { get; set; }
        public string? PaymentMethod { get; set; }
        
        // Additional Charges
        public List<AdditionalChargeDto>? AdditionalCharges { get; set; }
    }
    
    public class AdditionalChargeDto
    {
        public string? Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
