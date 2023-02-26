using AutoMapper;
using Cloud.Web;
using Clould.Service.Interface;
using Clould.Service.Implementation;
using Cloud.Infrastructure.Configuaration;

namespace Cloud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfiguarationService.Register(builder.Services);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
			builder.Services.AddSingleton(mapper);
			builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

			// Services
			builder.Services.AddTransient<IProductService, ProductService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}