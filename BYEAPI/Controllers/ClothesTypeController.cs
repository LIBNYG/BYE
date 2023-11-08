using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesTypeController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public ClothesTypeController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.ClothesTypes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClothesType clothesType)
        {
            _dbContext.Add(clothesType);
            _dbContext.SaveChanges();
            return Ok("Tipo de prenda de ropa almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] ClothesType clothesType)
        {
            var clothesTypeToUpdate = _dbContext.ClothesTypes.Find(id);
            if (clothesTypeToUpdate == null)
            {
                return NotFound();
            }

            clothesTypeToUpdate.Categy = clothesType.Categy;
            clothesTypeToUpdate.Name = clothesType.Name;

            _dbContext.SaveChanges();
            return Ok(clothesTypeToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var clothesType = _dbContext.ClothesTypes.Find(id);
            if (clothesType == null)
            {
                return NotFound();
            }

            _dbContext.ClothesTypes.Remove(clothesType);
            _dbContext.SaveChanges();
            return Ok("Tipo de prenda de ropa eliminado");
        }
    }
}
