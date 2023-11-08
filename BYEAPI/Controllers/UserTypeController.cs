using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserTypeController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public UserTypeController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.UserTypes.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserType userType)
        {
            _dbContext.UserTypes.Add(userType);
            _dbContext.SaveChanges();
            return Ok("Tipo de usuario almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] UserType userType)
        {
            var userTypeToUpdate = _dbContext.UserTypes.Find(id);
            if (userTypeToUpdate == null)
            {
                return NotFound();
            }

            userTypeToUpdate.AccessLevel = userType.AccessLevel;

            _dbContext.SaveChanges();
            return Ok(userTypeToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var userType = _dbContext.UserTypes.Find(id);
            if (userType == null)
            {
                return NotFound();
            }

            _dbContext.UserTypes.Remove(userType);
            _dbContext.SaveChanges();
            return Ok("Tipo de usuario eliminado");
        }
    }
}
