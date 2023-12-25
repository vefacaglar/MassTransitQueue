using MassTransit;

namespace Order.Api
{
    public class OrderCreatedConsumer : IConsumer<IOrderCreated>
    {
        private readonly IPublishEndpoint _endpoint;

        public OrderCreatedConsumer(
            IPublishEndpoint endpoint
            )
        {
            _endpoint = endpoint;
        }

        public async Task Consume(ConsumeContext<IOrderCreated> context)
        {
            Console.WriteLine("consumed somethings {0}", context.Message.OrderId);

            await _endpoint.Publish<IUpdateStock>(new
            {
                context.Message.OrderId,
                CreatedAt = DateTime.UtcNow,
            });
        }
    }
}
