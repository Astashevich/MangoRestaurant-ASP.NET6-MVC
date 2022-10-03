using Mango.Services.ShoppingCartAPI.Models.Dto;

namespace Mango.Services.ShoppingCartAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        public Task<CouponDto> GetCoupon(string couponName)
        {
            throw new NotImplementedException();
        }
    }
}
