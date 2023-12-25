using MassTransit;

namespace Stock.Api
{
    public class StockUpdateConsumer : IConsumer<IUpdateStock>
    {
        public StockUpdateConsumer()
        {
            
        }

        public async Task Consume(ConsumeContext<IUpdateStock> context)
        {
            Console.WriteLine("stock updated at product {0}", context.Message.OrderId);
        }
    }
}
