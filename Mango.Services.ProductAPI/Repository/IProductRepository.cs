using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProductsAsync();

        Task<ProductDto> GetProductByIdAsync(int productId);

        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);

        Task<bool> DeleteProductAsync(int productId);
    }
}
