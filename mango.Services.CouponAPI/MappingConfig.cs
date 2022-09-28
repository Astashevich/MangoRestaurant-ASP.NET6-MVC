using AutoMapper;
using mango.Services.CouponAPI.Models;
using mango.Services.CouponAPI.Models.Dto;

namespace Mango.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDto>().ReverseMap();
                
            });

            return mappingConfig;
        }
    }
}
