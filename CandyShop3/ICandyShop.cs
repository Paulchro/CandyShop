using CandyShop3.Models;

namespace CandyShop3
{
    public interface ICandyShop
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int id);
    }
}
