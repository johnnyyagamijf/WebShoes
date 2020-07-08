using Microsoft.AspNetCore.Mvc;
using WebShoes.Application.Contracts.Services;

namespace WebShoes.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("getbycategory/{id}")]
        public IActionResult GetByCategory(int categoryId)
        {
            var products = _productAppService.GetByCategory(categoryId);
            return Ok(products);
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            var products = _productAppService.GetAll();

            return Ok(products);
        }
    }
}