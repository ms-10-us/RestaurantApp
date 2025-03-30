namespace RestaurantAppAPI.DTOs
{
    public class OrdersDTO
    {
        public int OrderId { get; set; }

        public string? Description { get; set; }

        public string? Restaurant { get; set; }

        public bool OrderAgain { get; set; }
    }
}
