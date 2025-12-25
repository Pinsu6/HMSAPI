using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Data.Repositories.Interface
{
    public interface INotificationRepository
    {
        Task<ResponseDto> GetNotifications(NotificationReqDto req);
        Task<ResponseDto> MarkRead(NotificationReqDto req);
    }
}
