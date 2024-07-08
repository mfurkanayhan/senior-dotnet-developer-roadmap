using MediatR;

namespace Newsletter.Application.Features.Blogs.Create;

public sealed record BlogEvent(
    Guid BlogId) : INotification;