using EatMicroservices.Web.Models.Dto;

namespace EatMicroservices.Web.Service.IService
{
    public interface IBaseService
    {
      Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
