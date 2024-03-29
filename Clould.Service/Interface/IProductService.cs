﻿using Cloud.Core.Entities;
using Cloud.Infrastructure.Models.Dto;

namespace Clould.Service.Interface
{
	public interface IProductService
	{
		Task<IEnumerable<ProductDto>> GetProducts();
		Task<ProductDto> GetProductById(int productId);
		Task AddAsync(ProductDto product);
		Task<bool> DeleteProduct(int productId);
	}
}
