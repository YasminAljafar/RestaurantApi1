namespace RestaurantApi1.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public User? User { get; set; }
    }
}
