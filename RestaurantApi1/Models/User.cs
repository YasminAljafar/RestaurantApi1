namespace RestaurantApi1.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? HasRestauran { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int? RestaurantId { get; set; }

    }
}
