using Cloud.Infrastructure.Models.Dto;

namespace Clould.Service.Interface
{
	public interface IProductService
	{
		Task<IEnumerable<ProductDto>> GetProducts();
		Task<ProductDto> GetProductById(int productId);
		Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
		Task<bool> DeleteProduct(int productId);
	}
}
