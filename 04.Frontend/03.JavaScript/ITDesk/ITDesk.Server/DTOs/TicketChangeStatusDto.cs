namespace ITDesk.Server.DTOs;

public sealed record TicketChangeStatusDto(
    Guid Id,
    string Status
);