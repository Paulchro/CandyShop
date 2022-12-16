using CandyShop2.DAL;
using CandyShop3.Models;
using Microsoft.EntityFrameworkCore;

namespace CandyShop3.Services
{
    public class CandyShopRepository : ICandyShop
    {
        private readonly CandyShopContext _context;

        public CandyShopRepository(CandyShopContext candyShopContext)
        {
            _context = candyShopContext;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int id)
        {
            return await _context.Products.Where(x => x.CategoryId == id).ToListAsync();
        }
    }
}
