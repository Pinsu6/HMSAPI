using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface INotificationManager
    {
        Task<ResponseDto> GetNotifications(NotificationReqDto req);
        Task<ResponseDto> MarkRead(NotificationReqDto req);
    }
}
