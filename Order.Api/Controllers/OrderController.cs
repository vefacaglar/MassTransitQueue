using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IPublishEndpoint _endpoint;

        public OrderController(
            IPublishEndpoint endpoint
            )
        {
            _endpoint = endpoint;
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrder()
        {
            await _endpoint.Publish<IOrderCreated>(new
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTimeOffset.UtcNow,
                OrderId = Guid.NewGuid(),
            });

            return Ok();
        }
    }
}
