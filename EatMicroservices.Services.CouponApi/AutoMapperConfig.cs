using AutoMapper;
using EatMicroservices.Services.CouponApi.Models;
using EatMicroservices.Services.CouponApi.Models.Dto;
namespace EatMicroservices.Services.CouponApi
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });

            return mappingConfig;
        }
    }
}
