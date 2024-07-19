namespace QickServer.Domain.Users;

public interface IUserRepository
{
    Task<bool> CreateAsync(User user, CancellationToken cancellationToken = default);
    Task<bool> IsUserNameExists(UserName userName, CancellationToken cancellationToken = default);
    Task<User?> GetByUserNameAndPasswordAsync(UserName userName, Password password, CancellationToken cancellationToken = default);
}