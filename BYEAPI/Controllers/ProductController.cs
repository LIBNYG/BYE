using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public ProductController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Products.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return Ok("Producto almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Product product)
        {
            var productToUpdate = _dbContext.Products.Find(id);
            if (productToUpdate == null)
            {
                return NotFound();
            }

            productToUpdate.Type = product.Type;
            productToUpdate.Size = product.Size;
            productToUpdate.Color = product.Color;
            productToUpdate.Amount = product.Amount;

            _dbContext.SaveChanges();
            return Ok(productToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
            return Ok("Producto eliminado");
        }
    }
}
