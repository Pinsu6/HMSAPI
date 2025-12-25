using System.Threading.Tasks;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager
{
    public class NotificationManager : INotificationManager
    {
        private readonly INotificationRepository _repo;

        public NotificationManager(INotificationRepository repo)
        {
            _repo = repo;
        }

        public Task<ResponseDto> GetNotifications(NotificationReqDto req)
        {
            return _repo.GetNotifications(req);
        }

        public Task<ResponseDto> MarkRead(NotificationReqDto req)
        {
            return _repo.MarkRead(req);
        }
    }
}
