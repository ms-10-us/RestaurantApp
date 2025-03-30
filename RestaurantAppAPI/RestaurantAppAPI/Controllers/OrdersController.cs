using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantAppAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
            return Ok();
        }
    }
}
