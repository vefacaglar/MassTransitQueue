namespace MasstransitQueue.Application.Contracts
{
    public interface IUpdateStock
    {
        int OrderId { get; }
        DateTime CreatedAt { get; }
    }
}
