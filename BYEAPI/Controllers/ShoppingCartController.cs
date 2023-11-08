using Microsoft.AspNetCore.Mvc;
using ByeApi.Context;
using ByeApi.Models;
using System.Linq;

namespace ByeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ByeApiContext _dbContext;

        public ShoppingCartController(ByeApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.ShoppingCarts.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] ShoppingCart shoppingCart)
        {
            _dbContext.ShoppingCarts.Add(shoppingCart);
            _dbContext.SaveChanges();
            return Ok("Elemento del carrito de compras almacenado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] ShoppingCart shoppingCart)
        {
            var cartToUpdate = _dbContext.ShoppingCarts.Find(id);
            if (cartToUpdate == null)
            {
                return NotFound();
            }

            cartToUpdate.User = shoppingCart.User;
            cartToUpdate.Product = shoppingCart.Product;
            cartToUpdate.Amount = shoppingCart.Amount;

            _dbContext.SaveChanges();
            return Ok(cartToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var cart = _dbContext.ShoppingCarts.Find(id);
            if (cart == null)
            {
                return NotFound();
            }

            _dbContext.ShoppingCarts.Remove(cart);
            _dbContext.SaveChanges();
            return Ok("Elemento del carrito de compras eliminado");
        }
    }
}
