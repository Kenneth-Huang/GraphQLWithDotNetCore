using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLWithDotNet.Interfaces;
using GraphQLWithDotNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLWithDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProduct _productService;

        public ProductsController(IProduct productService)
        {
            _productService = productService;
        }
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        // POST: api/Products
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _productService.AddProduct(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product product)
        {
           return _productService.UpdateProduct(id, product);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
