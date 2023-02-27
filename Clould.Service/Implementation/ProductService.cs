using AutoMapper;
using Cloud.Core.Interface;
using Cloud.Infrastructure;
using Cloud.Infrastructure.Data;
using Cloud.Infrastructure.Models.Dto;
using Clould.Service.Interface;

namespace Clould.Service.Implementation
{
	public class ProductService : IProductService
	{
		private readonly MainDbContext _context;
		private readonly IProductRepository _productRepository;
		private readonly IUnitOfWork _unitOfWork;
		private IMapper _mapper;

		public ProductService(MainDbContext context, IMapper mapper, IProductRepository productRepository, IUnitOfWork unitOfWork)
		{
			_context = context;
			_mapper = mapper;
			_productRepository = productRepository;
			_unitOfWork = unitOfWork;
		}
		public async Task AddAsync(ProductDto product)
		{
			await _unitOfWork.BeginTransactionAsync();

			try
			{
				await _productRepository.AddAsync(new Cloud.Core.Entities.Product { CategoryName = product.Name});
				await _unitOfWork.CommitAsync();
			}
			catch
			{
				await _unitOfWork.RollbackAsync();
				
			}
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
			var products = await _productRepository.GetAllAsync();
			var productDTOs = _mapper.Map<List<ProductDto>>(products);

			return productDTOs;
		}
	}
}
