// Order DDD ye göre bir AggregateRoot'dur. AggregateRoot'lar birbirleri ile ilişkili olan Entity'lerin bir araya gelmesi ile oluşur.
public sealed class Order: Entity
{
    public Order(Guid id, string orderNumber, DateTime createdAt, OrderStatusEnum status): base(id)
    {
        OrderNumber = orderNumber;
        CreatedAt = createdAt;
        Status = status;
    }

    public string OrderNumber { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }

    public void CreteOrder(List<CreateOrderDto> createOrderDtos)
    {
        foreach (var createOrderDto in createOrderDtos)
        {
            if (createOrderDto.Quantity < 1)
            {
                throw new ArgumentException("Quantity must be greater than 0");
            }
            // other validations
            OrderLine orderLine =new(
                Guid.NewGuid(),
                Id,
                createOrderDto.ProductId,
                createOrderDto.Quantity,
                new(createOrderDto.Amount,Currency.FromCode(createOrderDto.Currency))
                );
        }
    }

    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderLine = OrderLines.FirstOrDefault(x => x.Id == orderLineId);
        if (orderLine is null)
        {
            throw new ArgumentException("Order line not found");
        }

        OrderLines.Remove(orderLine);
    }
}

