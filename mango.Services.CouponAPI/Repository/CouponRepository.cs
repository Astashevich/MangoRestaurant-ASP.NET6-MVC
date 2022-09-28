using AutoMapper;
using mango.Services.CouponAPI.Models.Dto;
using Mango.Services.CouponAPI.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace mango.Services.CouponAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CouponRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CouponDto> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await _context.Coupons.FirstOrDefaultAsync(u => u.CouponCode.Equals(couponCode));
            return _mapper.Map<CouponDto>(couponFromDb);
        }
    }
}
