using MassTransit;
using MasstransitQueue.Application.Contracts;

namespace Shipment.Api
{
    public class StockUpdateConsumer : IConsumer<IUpdateStock>
    {
        public async Task Consume(ConsumeContext<IUpdateStock> context)
        {
            Console.WriteLine("stock updated on shipment api {0}", context.Message.OrderId);
        }
    }
}
