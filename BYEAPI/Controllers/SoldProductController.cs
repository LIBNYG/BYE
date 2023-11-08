using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoldProductController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public SoldProductController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.SoldProducts.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] SoldProduct soldProduct)
        {
            _dbContext.SoldProducts.Add(soldProduct);
            _dbContext.SaveChanges();
            return Ok("Producto vendido almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] SoldProduct soldProduct)
        {
            var soldProductToUpdate = _dbContext.SoldProducts.Find(id);
            if (soldProductToUpdate == null)
            {
                return NotFound();
            }

            soldProductToUpdate.Type = soldProduct.Type;
            soldProductToUpdate.Size = soldProduct.Size;
            soldProductToUpdate.Color = soldProduct.Color;
            soldProductToUpdate.Amount = soldProduct.Amount;

            _dbContext.SaveChanges();
            return Ok(soldProductToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var soldProduct = _dbContext.SoldProducts.Find(id);
            if (soldProduct == null)
            {
                return NotFound();
            }

            _dbContext.SoldProducts.Remove(soldProduct);
            _dbContext.SaveChanges();
            return Ok("Producto vendido eliminado");
        }
    }
}
