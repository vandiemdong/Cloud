using AutoMapper;
using Cloud.Infrastructure.Models.Dto;
using Cloud.Infrastructure.Services.Interface;
using Cloud.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cloud.Web.Controllers
{
    public class ProductController : Controller
    {
		private IProductService _productService;
		private IMapper _mapper;
		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
        {
			var products = await _productService.GetProducts();

			return View(_mapper.Map<List<ProductViewModel>>(products));

		}
    }
}
