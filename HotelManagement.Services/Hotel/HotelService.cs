using System.Threading.Tasks;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Hotel.Interface;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Services.Hotel
{
    public class HotelService : IHotelService
    {
        private readonly IHotelManager _manager;

        public HotelService(IHotelManager manager)
        {
            _manager = manager;
        }

        public Task<ResponseDto> GetHotelInformation(HotelReqDto req)
        {
            return _manager.GetHotelInformation(req);
        }

        public Task<ResponseDto> InsertUpdateHotelInformation(HotelReqDto req)
        {
            return _manager.InsertUpdateHotelInformation(req);
        }

        public Task<ResponseDto> DeleteHotelInformation(HotelReqDto req)
        {
            return _manager.DeleteHotelInformation(req);
        }
    }
}
