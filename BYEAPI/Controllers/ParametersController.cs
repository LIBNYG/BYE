using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParametersController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public ParametersController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Parameters.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Parameters parameters)
        {
            _dbContext.Parameters.Add(parameters);
            _dbContext.SaveChanges();
            return Ok("Parámetro almacenado");
        }

        [HttpPut("{key}")]
        public IActionResult Put(string key, [FromBody] Parameters parameters)
        {
            var parameterToUpdate = _dbContext.Parameters.Find(key);
            if (parameterToUpdate == null)
            {
                return NotFound();
            }

            parameterToUpdate.Value = parameters.Value;

            _dbContext.SaveChanges();
            return Ok(parameterToUpdate);
        }

        [HttpDelete("{key}")]
        public IActionResult Delete(string key)
        {
            var parameter = _dbContext.Parameters.Find(key);
            if (parameter == null)
            {
                return NotFound();
            }

            _dbContext.Parameters.Remove(parameter);
            _dbContext.SaveChanges();
            return Ok("Parámetro eliminado");
        }
    }
}
