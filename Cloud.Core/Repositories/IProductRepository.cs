using Cloud.Core.Entities;

namespace Cloud.Core.Interface
{
	public interface IProductRepository
	{
		Task<Product> GetByIdAsync(int id);
		Task<IEnumerable<Product>> GetAllAsync();
		Task AddAsync(Product product);
		void Update(Product product);
		void Delete(Product product);
	}
}
