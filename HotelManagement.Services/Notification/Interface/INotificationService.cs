using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Notification.Interface
{
    public interface INotificationService
    {
        Task<ResponseDto> GetNotifications(NotificationReqDto req);
        Task<ResponseDto> MarkRead(NotificationReqDto req);
    }
}
