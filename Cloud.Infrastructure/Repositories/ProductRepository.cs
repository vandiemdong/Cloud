using Cloud.Core.Entities;
using Cloud.Core.Interface;
using Cloud.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Cloud.Infrastructure.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly MainDbContext _dbContext;

		public ProductRepository(MainDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Product> GetByIdAsync(int id)
		{
			return await _dbContext.Products.FindAsync(id);
		}

		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			return await _dbContext.Products.ToListAsync();
		}

		public async Task AddAsync(Product product)
		{
			await _dbContext.Products.AddAsync(product);
		}

		public void Update(Product product)
		{
			_dbContext.Products.Update(product);
		}

		public void Delete(Product product)
		{
			_dbContext.Products.Remove(product);
		}
	}
}
