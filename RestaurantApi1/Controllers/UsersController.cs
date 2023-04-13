using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantApi1.Data;
using RestaurantApi1.Models;

namespace RestaurantApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult> GetAllUsers(bool? IsHasRestaurant)
        {
            if (IsHasRestaurant == true)
            {
                var user = await _context.Users.Where(m => m.HasRestauran == true).ToListAsync();
                if (_context.Users == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            else if(IsHasRestaurant == false)
            {
                var user = await _context.Users.Where(m => m.HasRestauran == false).ToListAsync();
                if (_context.Users == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            else
            {
                var user = await _context.Users.ToListAsync();
                if (_context.Users == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Search(string ResStartWith, bool? IsHasReasturant )
        {
            if (IsHasReasturant== true )
            {
                var restaurant = _context.Restaurants.Where(m => m.Name.StartsWith(ResStartWith));
                var user1= restaurant.Where(m=>m.User.HasRestauran==true)
                    .Select(m => new User
                    {
                        Id = m.User.Id,
                        Name = m.User.Name,
                        HasRestauran = m.User.HasRestauran,
                        Restaurant=m.User.Restaurant

                    });
                return Ok(user1);
                
            }
            if (ResStartWith == null)
            {
                return BadRequest(" Enter letters");
            }
            else
            return BadRequest("the user don't have a restaurant");

        }
    }
}
