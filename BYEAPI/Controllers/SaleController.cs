using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public SaleController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Sales.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Sale sale)
        {
            _dbContext.Sales.Add(sale);
            _dbContext.SaveChanges();
            return Ok("Venta almacenada");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Sale sale)
        {
            var saleToUpdate = _dbContext.Sales.Find(id);
            if (saleToUpdate == null)
            {
                return NotFound();
            }

            saleToUpdate.User = sale.User;
            saleToUpdate.Product = sale.Product;
            saleToUpdate.Amount = sale.Amount;

            _dbContext.SaveChanges();
            return Ok(saleToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var sale = _dbContext.Sales.Find(id);
            if (sale == null)
            {
                return NotFound();
            }

            _dbContext.Sales.Remove(sale);
            _dbContext.SaveChanges();
            return Ok("Venta eliminada");
        }
    }
}
