using MediatR;
using Microsoft.EntityFrameworkCore;
using RestaurantAppAPI.Generated;
using RestaurantAppAPI.Models;

namespace RestaurantAppAPI.Applications.GetOrders
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, GetOrdersQueryResponse>
    {
        private readonly RestaurantAppDB _contextDb;


        public GetOrdersQueryHandler(RestaurantAppDB ContextDb) 
        {
            _contextDb = ContextDb;
        }


        public async Task<GetOrdersQueryResponse> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            GetOrdersQueryResponse response = new GetOrdersQueryResponse();

            List<Order> orderEntityList = await _contextDb.Orders.ToListAsync();

            response.OrderModel = await Task.FromResult(
                orderEntityList.Select(o => new OrderModel
                {
                    OrderId = o.OrderId,
                    Description = o.Description,
                    Restaurant = o.Restaurant,
                    Rating = o.Rating,
                    OrderAgain = o.OrderAgain,
                }).ToList());

            return response;    
        }
    }
}
