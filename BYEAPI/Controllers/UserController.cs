using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public UserController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Users.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return Ok("Usuario almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] User user)
        {
            var userToUpdate = _dbContext.Users.Find(id);
            if (userToUpdate == null)
            {
                return NotFound();
            }

            userToUpdate.FullName = user.FullName;
            userToUpdate.Type = user.Type;
            userToUpdate.IdentificationCard = user.IdentificationCard;

            _dbContext.SaveChanges();
            return Ok(userToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var user = _dbContext.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
            return Ok("Usuario eliminado");
        }
    }
}
