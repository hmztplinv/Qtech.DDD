public interface IProductRepository
{
    Task CreateAsync(string name,int quantity, decimal amount, string currency, Guid categoryId, CancellationToken cancellationToken = default);
    Task<List<Product>> GetListAsync(CancellationToken cancellationToken = default);
}