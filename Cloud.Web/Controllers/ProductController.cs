using Cloud.Infrastructure.Models.Dto;
using Cloud.Infrastructure.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cloud.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }
    }
}