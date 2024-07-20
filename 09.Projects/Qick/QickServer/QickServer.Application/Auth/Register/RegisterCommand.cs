using MediatR;
using MFA.Result;

namespace QickServer.Applicaiton.Auth.Register;
public sealed record RegisterCommand(
    string UserName,
    string Password) : IRequest<Result<string>>;
