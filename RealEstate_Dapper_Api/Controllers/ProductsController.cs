using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductlistWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ChangeProductDealFalse/{id}")]
        public async Task<IActionResult> ChangeProductDealFalse(int id)
        {
            _productRepository.ChangeProductDealFalse(id);
            return Ok("The product has been removed from the deal of the day.");
        }

        [HttpGet("ChangeProductDealTrue/{id}")]
        public async Task<IActionResult> ChangeProductDealTrue(int id)
        {
            _productRepository.ChangeProductDealTrue(id);
            return Ok("Product has been added to the deal of the day.");
        }


    }
}
