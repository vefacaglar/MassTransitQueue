namespace MasstransitQueue.Application.Contracts
{
    public interface IUpdateStock
    {
        Guid OrderId { get; }
        DateTime CreatedAt { get; }
    }
}
