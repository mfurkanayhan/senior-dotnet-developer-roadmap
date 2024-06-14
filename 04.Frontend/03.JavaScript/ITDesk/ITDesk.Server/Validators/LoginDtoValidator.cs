using FluentValidation;
using ITDesk.Server.DTOs;

namespace ITDesk.Server.Validators;

public sealed class LoginDtoValidator : AbstractValidator<LoginDto>
{
    public LoginDtoValidator()
    {
        RuleFor(p => p.UsernameOrEmail).NotEmpty().WithMessage("Please enter a valid username or email address");
        RuleFor(p => p.UsernameOrEmail).NotNull().WithMessage("Please enter a valid username or email address");
        RuleFor(p => p.UsernameOrEmail).MinimumLength(3).WithMessage("The username or email address field must be at least 3 characters long");

        RuleFor(p => p.Password).NotEmpty().WithMessage("Please enter a valid password");
        RuleFor(p => p.Password).NotNull().WithMessage("Please enter a valid password");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Your password must contain at least 1 uppercase letter");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Your password must contain at least 1 lowercase letter");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Your password must contain at least 1 digit");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Your password must contain at least 1 special character");
    }
}
