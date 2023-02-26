
using Cloud.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cloud.Infrastructure.Configuaration
{
	public class ConfiguarationService
	{
		public static void Register(IServiceCollection services)
		{
			services.AddDbContext<MainDbContext>(options =>
				options.UseSqlServer("name=ConnectionStrings:DefaultConnection",
				x => x.MigrationsAssembly("Cloud.Infrastructure")));
		}
	}
}
