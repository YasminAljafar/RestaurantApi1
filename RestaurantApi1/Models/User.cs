namespace RestaurantApi1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
        public int UserTypeId { get; set; }

        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }

    }
}
