public interface ICategoryRepository
{
    Task CreateAsync(string name, CancellationToken cancellationToken = default);
    Task<List<Category>> GetListAsync(CancellationToken cancellationToken = default);
    // Task<Category> GetAsync(Guid id, CancellationToken cancellationToken = default);
    // Task UpdateAsync(Category category, CancellationToken cancellationToken = default);
    // Task DeleteAsync(Category category, CancellationToken cancellationToken = default);
}