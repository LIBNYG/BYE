using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public OrderController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Orders.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return Ok("Orden almacenada");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Order order)
        {
            var orderToUpdate = _dbContext.Orders.Find(id);
            if (orderToUpdate == null)
            {
                return NotFound();
            }

            orderToUpdate.Product = order.Product;
            orderToUpdate.Amount = order.Amount;

            _dbContext.SaveChanges();
            return Ok(orderToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var order = _dbContext.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            _dbContext.Orders.Remove(order);
            _dbContext.SaveChanges();
            return Ok("Orden eliminada");
        }
    }
}
