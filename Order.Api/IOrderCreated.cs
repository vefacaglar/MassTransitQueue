namespace Order.Api
{
    public interface IOrderCreated
    {
        DateTime CreatedAt { get; }
        Guid OrderId { get; }
    }
}
