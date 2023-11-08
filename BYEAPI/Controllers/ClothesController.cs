using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public ClothesController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Clothes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Clothes clothes)
        {
            _dbContext.Add(clothes);
            _dbContext.SaveChanges();
            return Ok("Prenda de ropa almacenada");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Clothes clothes)
        {
            var clothesToUpdate = _dbContext.Clothes.Find(id);
            if (clothesToUpdate == null)
            {
                return NotFound();
            }

            clothesToUpdate.Name = clothes.Name;
            clothesToUpdate.Type = clothes.Type;

            _dbContext.SaveChanges();
            return Ok(clothesToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var clothes = _dbContext.Clothes.Find(id);
            if (clothes == null)
            {
                return NotFound();
            }

            _dbContext.Clothes.Remove(clothes);
            _dbContext.SaveChanges();
            return Ok("Prenda de ropa eliminada");
        }
    }
}
