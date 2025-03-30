using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantAppAPI.Applications.GetOrders;
using RestaurantAppAPI.DTOs;
using RestaurantAppAPI.Mapper;

namespace RestaurantAppAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
         
        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {

            GetOrdersQuery query = new GetOrdersQuery();

            GetOrdersQueryResponse responseModel = await _mediator.Send(query);

            GetOrdersResponseDTO response = responseModel.ToDto();

            return Ok(response);
        }
    }
}
