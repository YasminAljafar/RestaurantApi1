using Microsoft.EntityFrameworkCore;
using RestaurantApi1.Models;

namespace RestaurantApi1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set;}
     
    }
}
