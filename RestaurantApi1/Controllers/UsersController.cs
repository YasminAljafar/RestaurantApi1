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
        public async Task<ActionResult> GetAllUsers()
        {
            var user = await _context.Users.ToListAsync();
            if (_context.Users == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Search(string term)
        {
           
                var user = _context.Users.Where(m => m.Name.Contains(term))
                    .Select(m => new User
                    {
                        Id = m.Id,
                        Name = m.Name,
                        Email = m.Email,
                        Password = m.Password,
                        UserType = m.UserType,
                        Restaurant=m.Restaurant,

                    });
                return Ok(user);

      
        }
    }
}
