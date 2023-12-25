namespace Order.Api
{
    public interface IUpdateStock
    {
        int OrderId { get; }
        DateTime CreatedAt { get; }
    }
}
