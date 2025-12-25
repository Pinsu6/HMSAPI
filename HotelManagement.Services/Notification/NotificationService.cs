using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Notification.Interface;
using HotelManagement.ViewModels.RequestModels;
using HotelManagement.ViewModels.ViewModels;

namespace HotelManagement.Services.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationManager _manager;

        public NotificationService(INotificationManager manager)
        {
            _manager = manager;
        }

        public async Task<ResponseDto> GetNotifications(NotificationReqDto req)
        {
            return await _manager.GetNotifications(req);
        }

        public async Task<ResponseDto> MarkRead(NotificationReqDto req)
        {
            return await _manager.MarkRead(req);
        }
    }
}
