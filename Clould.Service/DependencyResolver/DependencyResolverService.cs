using Clould.Service.Implementation;
using Clould.Service.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace Clould.Service.Configuaration
{
	public class DependencyResolverService
	{
		public static void Register(IServiceCollection services)
		{
			services.AddScoped<IProductService, ProductService>();
		}
	}
}
