namespace ITDesk.Server.DTOs;

public sealed record LoginResponseDto(
    string AccessToken,
    Guid UserId
);