using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }

        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductBrand>>> GetProductBrands()
        {
            var products = await _repo.GetProductBrandsAsync();
            return Ok(products);
        }

        [HttpGet("brands/{id}")]
        public async Task<ActionResult<ProductBrand>> GetProductBrand(int id)
        {
            return await _repo.GetProductBrandByIdAsync(id);
        }

        [HttpGet("types")]
        public async Task<ActionResult<List<ProductType>>> GetProductTypes()
        {
            var products = await _repo.GetProductTypesAsync();
            return Ok(products);
        }

        [HttpGet("types/{id}")]
        public async Task<ActionResult<ProductType>> GetProductType(int id)
        {
            return await _repo.GetProductTypeByIdAsync(id);
        }




    }
}