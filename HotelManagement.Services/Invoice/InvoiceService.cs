using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Invoice.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace HotelManagement.Services.Invoice
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceManager _manager;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _basePath;

        public InvoiceService(IInvoiceManager manager, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _manager = manager;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            // Get base path from configuration or use default
            _basePath = _configuration["InvoicePath"] ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        }

        public Task<ResponseDto> GetInvoices(InvoiceReqDto req)
        {
            return _manager.GetInvoices(req);
        }

        public async Task<ResponseDto> InsertUpdateInvoice(InvoiceReqDto req)
        {
            try
            {
                // Generate Invoice Number if not provided
                if (string.IsNullOrEmpty(req.InvoiceNumber))
                {
                    req.InvoiceNumber = $"INV-{DateTime.Now:yyyyMMddHHmmss}-{req.BookingId}";
                }

                // Create InvoiceData for PDF generation
                var invoiceData = new InvoiceData
                {
                    InvoiceNumber = req.InvoiceNumber,
                    BookingId = req.BookingId ?? 0,
                    GuestName = req.GuestName ?? "Guest",
                    GuestMobile = req.GuestMobile ?? "-",
                    GuestEmail = req.GuestEmail ?? "-",
                    IdProofType = req.IdProofType ?? "-",
                    IdProofNumber = req.IdProofNumber ?? "-",
                    RoomNumber = req.RoomNumber ?? "-",
                    RoomType = req.RoomType ?? "-",
                    CheckInDate = req.CheckInDate ?? DateTime.Now,
                    CheckOutDate = req.CheckOutDate ?? DateTime.Now,
                    Adults = req.Adults ?? 1,
                    Children = req.Children ?? 0,
                    TotalNights = req.TotalNights ?? 1,
                    RoomRate = req.RoomRate ?? 0,
                    SubTotal = req.SubTotal ?? 0,
                    TaxPercentage = req.TaxPercentage ?? 18,
                    TaxAmount = req.TaxAmount ?? 0,
                    Discount = req.Discount ?? 0,
                    GrandTotal = req.GrandTotal ?? 0,
                    PaymentStatus = req.PaymentStatus ?? "Pending",
                    PaymentMethod = req.PaymentMethod ?? "Cash",
                    AdditionalCharges = ConvertToChargeItems(req.AdditionalCharges)
                };

                // Generate PDF
                string relativePdfPath = InvoicePdfGenerator.GenerateInvoicePdf(invoiceData, _basePath);
                
                // Get dynamic server base URL
                string baseUrl = GetServerBaseUrl();
                
                // Create full HTTP URL for PDF
                string fullPdfUrl = $"{baseUrl}/{relativePdfPath}";
                
                // Update the request with full PDF URL
                req.PdfPath = fullPdfUrl;
                req.CreatedOn = DateTime.Now;

                // Save to database
                return await _manager.InsertUpdateInvoice(req);
            }
            catch (Exception ex)
            {
                return new ResponseDto
                {
                    Status = "Error",
                    Message = $"Error generating invoice: {ex.Message}",
                    ResponseData = null
                };
            }
        }

        private string GetServerBaseUrl()
        {
            var request = _httpContextAccessor.HttpContext?.Request;
            if (request != null)
            {
                // Build URL like: https://localhost:7287 or http://yourserver.com
                return $"{request.Scheme}://{request.Host}";
            }
            
            // Fallback to configuration if HttpContext is not available
            return _configuration["ServerBaseUrl"] ?? "http://localhost:5000";
        }

        private List<ChargeItem>? ConvertToChargeItems(List<AdditionalChargeDto>? charges)
        {
            if (charges == null) return null;

            var chargeItems = new List<ChargeItem>();
            foreach (var charge in charges)
            {
                chargeItems.Add(new ChargeItem
                {
                    Description = charge.Description,
                    Quantity = charge.Quantity,
                    Rate = charge.Rate,
                    Amount = charge.Amount
                });
            }
            return chargeItems;
        }
    }
}
