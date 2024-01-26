public sealed class Order: Entity
{
    public Order(Guid id, string orderNumber, DateTime createdAt, OrderStatusEnum status, ICollection<OrderLine> orderLines): base(id)
    {
        OrderNumber = orderNumber;
        CreatedAt = createdAt;
        Status = status;
        OrderLines = orderLines;
    }

    public string OrderNumber { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }
}