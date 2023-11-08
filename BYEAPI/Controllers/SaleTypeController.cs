using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleTypeController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public SaleTypeController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.SaleTypes.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] SaleType saleType)
        {
            _dbContext.SaleTypes.Add(saleType);
            _dbContext.SaveChanges();
            return Ok("Tipo de venta almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] SaleType saleType)
        {
            var saleTypeToUpdate = _dbContext.SaleTypes.Find(id);
            if (saleTypeToUpdate == null)
            {
                return NotFound();
            }

            saleTypeToUpdate.Name = saleType.Name;

            _dbContext.SaveChanges();
            return Ok(saleTypeToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var saleType = _dbContext.SaleTypes.Find(id);
            if (saleType == null)
            {
                return NotFound();
            }

            _dbContext.SaleTypes.Remove(saleType);
            _dbContext.SaveChanges();
            return Ok("Tipo de venta eliminado");
        }
    }
}
