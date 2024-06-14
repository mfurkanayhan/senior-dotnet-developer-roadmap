namespace ITDesk.Server.DTOs;

public sealed record TicketCreateDto(
    string Subject,
    string IsUrgent,
    Guid UserId
);