public interface IUserRepository
{
    Task CreateAsync(string name,string email,string password,string country,string city,string street,string fullAddress,string zipCode, CancellationToken cancellationToken = default);
    Task<List<User>> GetListAsync(CancellationToken cancellationToken = default);
}