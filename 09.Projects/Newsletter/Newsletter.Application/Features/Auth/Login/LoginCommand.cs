using MediatR;
using MFA.Result;

namespace Newsletter.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string UserNameOrEmail,
    string Password) : IRequest<Result<string>>;
