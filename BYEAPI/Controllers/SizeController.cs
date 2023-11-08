using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SizeController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public SizeController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Sizes.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Size size)
        {
            _dbContext.Sizes.Add(size);
            _dbContext.SaveChanges();
            return Ok("Tamaño almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Size size)
        {
            var sizeToUpdate = _dbContext.Sizes.Find(id);
            if (sizeToUpdate == null)
            {
                return NotFound();
            }

            sizeToUpdate.MaxAge = size.MaxAge;
            sizeToUpdate.MinAge = size.MinAge;

            _dbContext.SaveChanges();
            return Ok(sizeToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var size = _dbContext.Sizes.Find(id);
            if (size == null)
            {
                return NotFound();
            }

            _dbContext.Sizes.Remove(size);
            _dbContext.SaveChanges();
            return Ok("Tamaño eliminado");
        }
    }
}
