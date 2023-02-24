using Cloud.Infrastructure.Models.Dto;
using Clould.Service.Interface;

namespace Clould.Service.Implementation
{
	public class ProductService : IProductService
	{
		public Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteProduct(int productId)
		{
			throw new NotImplementedException();
		}

		public Task<ProductDto> GetProductById(int productId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<ProductDto>> GetProducts()
		{

			var result = await Task.Run(() => GetSampleProducts());

			return result;
		}

		private List<ProductDto> GetSampleProducts()
		{
			var list = new List<ProductDto>();
			list.Add(new ProductDto() { ProductId = 1, Price = 20, Name = "Kavin" });
			list.Add(new ProductDto() { ProductId = 2, Price = 30, Name = "Alen" });
			list.Add(new ProductDto() { ProductId = 3, Price = 20, Name = "Suresh" });
			list.Add(new ProductDto() { ProductId = 4, Price = 30, Name = "Jay" });
			list.Add(new ProductDto() { ProductId = 5, Price = 20, Name = "Nanda" });
			list.Add(new ProductDto() { ProductId = 5, Price = 20, Name = "Kavin" });
			list.Add(new ProductDto() { ProductId = 5, Price = 20, Name = "Kavin" });
			list.Add(new ProductDto() { ProductId = 1, Price = 23, Name = "Test" });

			return list.ToList();
		}
	}
}
