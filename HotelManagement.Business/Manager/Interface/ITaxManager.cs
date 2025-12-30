using System.Threading.Tasks;
using HotelManagement.ViewModels.ViewModels;
using HotelManagement.ViewModels.RequestModels;

namespace HotelManagement.Business.Manager.Interface
{
    public interface ITaxManager
    {
        Task<ResponseDto> GetTax(TaxReqDto req);
        Task<ResponseDto> AddTax(TaxReqDto req);
        Task<ResponseDto> DeleteTax(TaxReqDto req);
    }
}
