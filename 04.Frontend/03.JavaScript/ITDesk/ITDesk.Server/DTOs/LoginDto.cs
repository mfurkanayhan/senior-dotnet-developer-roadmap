namespace ITDesk.Server.DTOs;

public sealed record LoginDto(
    string UsernameOrEmail,
    string Password,
    bool RememberMe
);