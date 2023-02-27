using AutoMapper;
using Cloud.Core.Entities;
using Cloud.Infrastructure.Models.Dto;

namespace Clould.Service
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(config =>
			{
				config.CreateMap<Product, ProductDto>();
			});

			return mappingConfig;
		}
	}
}
