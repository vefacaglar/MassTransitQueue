namespace Order.Api
{
    public interface IOrderCreated
    {
        DateTime CreatedAt { get; }
        int OrderId { get; }
    }
}
