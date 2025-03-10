using sushiAPI.Entities;

namespace sushiAPI.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProduct(int id);
        Task<Product> AddProduct(Product product, List<IFormFile> files);
        Task<Product?> UpdateProduct(int id, Product product, List<IFormFile> files);
        Task<Product?> DeleteProduct(int id);
    }
}