using AutoMapper;
using Cloud.Infrastructure.Models.Dto;
using Cloud.Web.Models;

namespace Cloud.Web
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<ProductViewModel, ProductDto>();
				config.CreateMap<ProductDto, ProductViewModel>();
			});

			return mappingConfig;
		}
	}
}
