using QickServer.Domain.Shared;

namespace QickServer.Domain.Users;
public sealed class User : Entity
{
    public User(UserName userName, Password password)
    {
        UserName = userName;
        Password = password;        
    }
    public UserName UserName { get; private set; }
    public Password Password { get; private set; }
}
