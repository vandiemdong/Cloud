﻿
using Cloud.Core.Interface;
using Cloud.Infrastructure.Data;
using Cloud.Infrastructure.Repositories;
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

			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
		}
	}
}
