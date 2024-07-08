using MediatR;
using MFA.Result;

namespace Newsletter.Application.Features.Blogs.ChangeStatus;
public sealed record ChangeStatusCommand(
    Guid Id) : IRequest<Result<string>>;
