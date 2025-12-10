using System.Text.Json;

namespace HotelManagement.ViewModels.ViewModels
{
    public class ResponseDto
    {
        public string? Status { get; set; }
        public string? Type { get; set; }
        public int? TotalCount { get; set; }
        public string? Message { get; set; }
        public string? ResponseData { get; set; }
        public string? Token { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
