using EatMicroservices.Web.Models.Dto;
using EatMicroservices.Web.Service.IService;
using EatMicroservices.Web.Utils;

namespace EatMicroservices.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService) { }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                RequestType = StaticDetails.RequestType.POST,
                Data = couponDto,
                Url = StaticDetails.CouponApiBaseUrl + "/api/coupon/"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                RequestType = StaticDetails.RequestType.DELETE,
                Url = StaticDetails.CouponApiBaseUrl + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                RequestType = StaticDetails.RequestType.GET,
                Url = StaticDetails.CouponApiBaseUrl + "/api/coupon/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                RequestType = StaticDetails.RequestType.GET,
                Url = StaticDetails.CouponApiBaseUrl+"/api/coupon"
            });
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                RequestType = StaticDetails.RequestType.GET,
                Url = StaticDetails.CouponApiBaseUrl + "/api/coupon/GetByCode/"+couponCode
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                RequestType = StaticDetails.RequestType.PUT,
                Data = couponDto,
                Url = StaticDetails.CouponApiBaseUrl + "/api/coupon/"
            });
        }
    }
}
