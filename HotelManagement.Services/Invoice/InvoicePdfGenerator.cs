using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace HotelManagement.Services.Invoice
{
    public class InvoicePdfGenerator
    {
        public static string GenerateInvoicePdf(InvoiceData invoiceData, string basePath)
        {
            // Configure QuestPDF license (Community license is free)
            QuestPDF.Settings.License = LicenseType.Community;

            // Create unique invoice number if not provided
            string invoiceNumber = invoiceData.InvoiceNumber ?? $"INV-{DateTime.Now:yyyyMMddHHmmss}";
            
            // Create filename
            string fileName = $"{invoiceNumber}.pdf";
            string folderPath = Path.Combine(basePath, "Invoices");
            
            // Ensure directory exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            
            string fullPath = Path.Combine(folderPath, fileName);

            // Generate PDF
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(11));

                    // Header
                    page.Header().Element(container => ComposeHeader(container, invoiceNumber, invoiceData));

                    // Content
                    page.Content().Element(container => ComposeContent(container, invoiceData));

                    // Footer
                    page.Footer().Element(ComposeFooter);
                });
            })
            .GeneratePdf(fullPath);

            return $"Invoices/{fileName}";
        }

        static void ComposeHeader(IContainer container, string invoiceNumber, InvoiceData data)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item()
                        .Text("HOTEL INVOICE")
                        .Bold()
                        .FontSize(28)
                        .FontColor(Colors.Blue.Darken2);
                    
                    column.Item().PaddingTop(5).Text($"Invoice #: {invoiceNumber}")
                        .FontSize(14)
                        .FontColor(Colors.Grey.Darken1);
                });

                row.RelativeItem().Column(column =>
                {
                    column.Item().AlignRight().Text("Hotel Management System")
                        .Bold()
                        .FontSize(14);
                    column.Item().AlignRight().Text("Your Premium Stay Partner")
                        .FontSize(10)
                        .FontColor(Colors.Grey.Darken1);
                    column.Item().AlignRight().PaddingTop(5).Text($"Date: {DateTime.Now:dd MMM yyyy}")
                        .FontSize(10);
                });
            });
        }

        static void ComposeContent(IContainer container, InvoiceData data)
        {
            container.PaddingVertical(20).Column(column =>
            {
                // Guest Information Section
                column.Item().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingBottom(15).Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("BILLING INFORMATION")
                            .Bold()
                            .FontSize(13)
                            .FontColor(Colors.Blue.Darken2);
                        col.Item().PaddingTop(8).Text($"Guest Name: {data.GuestName}");
                        col.Item().Text($"Mobile: {data.GuestMobile}");
                        col.Item().Text($"Email: {data.GuestEmail}");
                        col.Item().Text($"ID Proof: {data.IdProofType} - {data.IdProofNumber}");
                    });

                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("STAY DETAILS")
                            .Bold()
                            .FontSize(13)
                            .FontColor(Colors.Blue.Darken2);
                        col.Item().PaddingTop(8).Text($"Room Number: {data.RoomNumber}");
                        col.Item().Text($"Room Type: {data.RoomType}");
                        col.Item().Text($"Check-In: {data.CheckInDate:dd MMM yyyy, hh:mm tt}");
                        col.Item().Text($"Check-Out: {data.CheckOutDate:dd MMM yyyy, hh:mm tt}");
                        col.Item().Text($"Adults: {data.Adults} | Children: {data.Children}");
                    });
                });

                // Charges Table
                column.Item().PaddingTop(20).Text("CHARGES BREAKDOWN")
                    .Bold()
                    .FontSize(13)
                    .FontColor(Colors.Blue.Darken2);

                column.Item().PaddingTop(10).Table(table =>
                {
                    // Define columns
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(50);  // S.No
                        columns.RelativeColumn(3);   // Description
                        columns.RelativeColumn(1);   // Quantity
                        columns.RelativeColumn(1);   // Rate
                        columns.RelativeColumn(1);   // Amount
                    });

                    // Header
                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Blue.Darken2).Padding(8)
                            .Text("S.No").Bold().FontColor(Colors.White);
                        header.Cell().Background(Colors.Blue.Darken2).Padding(8)
                            .Text("Description").Bold().FontColor(Colors.White);
                        header.Cell().Background(Colors.Blue.Darken2).Padding(8)
                            .Text("Qty").Bold().FontColor(Colors.White);
                        header.Cell().Background(Colors.Blue.Darken2).Padding(8)
                            .Text("Rate").Bold().FontColor(Colors.White);
                        header.Cell().Background(Colors.Blue.Darken2).Padding(8)
                            .Text("Amount").Bold().FontColor(Colors.White);
                    });

                    // Data rows
                    int serialNo = 1;
                    
                    // Room Charges
                    if (data.TotalNights > 0)
                    {
                        AddTableRow(table, serialNo++, $"Room Charges ({data.TotalNights} Night(s))", 
                            data.TotalNights, data.RoomRate, data.TotalNights * data.RoomRate);
                    }

                    // Additional Charges
                    if (data.AdditionalCharges != null)
                    {
                        foreach (var charge in data.AdditionalCharges)
                        {
                            AddTableRow(table, serialNo++, charge.Description, 
                                charge.Quantity, charge.Rate, charge.Amount);
                        }
                    }
                });

                // Totals Section
                column.Item().PaddingTop(15).AlignRight().Width(250).Column(col =>
                {
                    col.Item().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Row(row =>
                    {
                        row.RelativeItem().Text("Subtotal:").Bold();
                        row.RelativeItem().AlignRight().Text($"₹{data.SubTotal:N2}");
                    });

                    col.Item().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Row(row =>
                    {
                        row.RelativeItem().Text($"Tax ({data.TaxPercentage}%):").Bold();
                        row.RelativeItem().AlignRight().Text($"₹{data.TaxAmount:N2}");
                    });

                    if (data.Discount > 0)
                    {
                        col.Item().BorderBottom(1).BorderColor(Colors.Grey.Lighten2).Padding(5).Row(row =>
                        {
                            row.RelativeItem().Text("Discount:").Bold();
                            row.RelativeItem().AlignRight().Text($"-₹{data.Discount:N2}").FontColor(Colors.Green.Darken2);
                        });
                    }

                    col.Item().Background(Colors.Blue.Lighten4).Padding(8).Row(row =>
                    {
                        row.RelativeItem().Text("GRAND TOTAL:").Bold().FontSize(14);
                        row.RelativeItem().AlignRight().Text($"₹{data.GrandTotal:N2}")
                            .Bold().FontSize(14).FontColor(Colors.Blue.Darken2);
                    });
                });

                // Payment Info
                column.Item().PaddingTop(20).BorderTop(1).BorderColor(Colors.Grey.Lighten2).PaddingTop(15).Row(row =>
                {
                    row.RelativeItem().Column(col =>
                    {
                        col.Item().Text("PAYMENT INFORMATION")
                            .Bold()
                            .FontSize(13)
                            .FontColor(Colors.Blue.Darken2);
                        col.Item().PaddingTop(8).Text($"Payment Status: {data.PaymentStatus}");
                        col.Item().Text($"Payment Method: {data.PaymentMethod}");
                    });
                });

                // Terms and Conditions
                column.Item().PaddingTop(25).Text("Terms & Conditions")
                    .Bold().FontSize(11).FontColor(Colors.Grey.Darken2);
                column.Item().PaddingTop(5).Text("• Check-out time is 12:00 PM")
                    .FontSize(9).FontColor(Colors.Grey.Darken1);
                column.Item().Text("• Late check-out may incur additional charges")
                    .FontSize(9).FontColor(Colors.Grey.Darken1);
                column.Item().Text("• This is a computer-generated invoice and does not require signature")
                    .FontSize(9).FontColor(Colors.Grey.Darken1);
            });
        }

        static void AddTableRow(TableDescriptor table, int serialNo, string description, 
            decimal quantity, decimal rate, decimal amount)
        {
            var backgroundColor = serialNo % 2 == 0 ? Colors.Grey.Lighten4 : Colors.White;
            
            table.Cell().Background(backgroundColor).Padding(6).Text(serialNo.ToString());
            table.Cell().Background(backgroundColor).Padding(6).Text(description);
            table.Cell().Background(backgroundColor).Padding(6).AlignCenter().Text(quantity.ToString("N0"));
            table.Cell().Background(backgroundColor).Padding(6).AlignRight().Text($"₹{rate:N2}");
            table.Cell().Background(backgroundColor).Padding(6).AlignRight().Text($"₹{amount:N2}");
        }

        static void ComposeFooter(IContainer container)
        {
            container.AlignCenter().Padding(20).Column(column =>
            {
                column.Item().Text("Thank you for staying with us!")
                    .Bold()
                    .FontSize(14)
                    .FontColor(Colors.Blue.Darken2);
                column.Item().PaddingTop(5).Text("We hope to see you again!")
                    .FontSize(10)
                    .FontColor(Colors.Grey.Darken1);
                column.Item().PaddingTop(10).Text($"Generated on: {DateTime.Now:dd MMM yyyy, hh:mm tt}")
                    .FontSize(8)
                    .FontColor(Colors.Grey.Medium);
            });
        }
    }

    // Data class for invoice
    public class InvoiceData
    {
        public string? InvoiceNumber { get; set; }
        public int BookingId { get; set; }
        
        // Guest Info
        public string? GuestName { get; set; }
        public string? GuestMobile { get; set; }
        public string? GuestEmail { get; set; }
        public string? IdProofType { get; set; }
        public string? IdProofNumber { get; set; }
        
        // Room Info
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        
        // Stay Info
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int TotalNights { get; set; }
        
        // Charges
        public decimal RoomRate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        
        // Payment
        public string? PaymentStatus { get; set; }
        public string? PaymentMethod { get; set; }
        
        // Additional Charges
        public List<ChargeItem>? AdditionalCharges { get; set; }
    }

    public class ChargeItem
    {
        public string? Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
