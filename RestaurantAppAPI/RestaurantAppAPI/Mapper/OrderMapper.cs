using RestaurantAppAPI.Applications.GetOrders;
using RestaurantAppAPI.DTOs;

namespace RestaurantAppAPI.Mapper
{
    public static class OrderMapper
    {
        public static GetOrdersResponseDTO ToDto(this GetOrdersQueryResponse response)
        {
            GetOrdersResponseDTO dto = new GetOrdersResponseDTO();

            dto.ordersDTO =  response.OrderModel.Select(om => new OrdersDTO
            {
                OrderId = om.OrderId,
                Description = om.Description,
                Restaurant = om.Restaurant,
                OrderAgain = om.OrderAgain,
            }).ToList();

            return dto;

        }
    }
}
