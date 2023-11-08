using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SonnyController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public SonnyController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Sonnies.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Sonny sonny)
        {
            _dbContext.Sonnies.Add(sonny);
            _dbContext.SaveChanges();
            return Ok("Sonny almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Sonny sonny)
        {
            var sonnyToUpdate = _dbContext.Sonnies.Find(id);
            if (sonnyToUpdate == null)
            {
                return NotFound();
            }

            sonnyToUpdate.FullName = sonny.FullName;
            sonnyToUpdate.User = sonny.User;
            sonnyToUpdate.Birthdate = sonny.Birthdate;

            _dbContext.SaveChanges();
            return Ok(sonnyToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var sonny = _dbContext.Sonnies.Find(id);
            if (sonny == null)
            {
                return NotFound();
            }

            _dbContext.Sonnies.Remove(sonny);
            _dbContext.SaveChanges();
            return Ok("Sonny eliminado");
        }
    }
}
