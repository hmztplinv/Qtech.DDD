public interface IOrderRepository
{
    Task CreateAsync(List<CreateOrderDto> createOrderDtos, CancellationToken cancellationToken = default);
    Task<List<Order>> GetListAsync(CancellationToken cancellationToken = default);
}