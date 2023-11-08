using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public ColorController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Colors);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Color color)
        {
            _dbContext.Add(color);
            _dbContext.SaveChanges();
            return Ok("Color almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Color color)
        {
            var colorToUpdate = _dbContext.Colors.Find(id);
            if (colorToUpdate == null)
            {
                return NotFound();
            }

            colorToUpdate.Name = color.Name;

            _dbContext.SaveChanges();
            return Ok(colorToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var color = _dbContext.Colors.Find(id);
            if (color == null)
            {
                return NotFound();
            }

            _dbContext.Colors.Remove(color);
            _dbContext.SaveChanges();
            return Ok("Color eliminado");
        }
    }
}
