namespace RestaurantAppAPI.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        public string Description { get; set; } = null!;

        public string Restaurant { get; set; } = null!;

        public int? Rating { get; set; }

        public bool OrderAgain { get; set; }
    }
}
