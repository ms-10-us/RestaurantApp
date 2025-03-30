using RestaurantAppAPI.Models;

namespace RestaurantAppAPI.Applications.GetOrders
{
    public class GetOrdersQueryResponse
    {
        public List<OrderModel> OrderModel { get; set; }
    }
}
