using FluentValidation;
using ITDesk.Server.DTOs;

namespace ITDesk.Server.Validators;

public sealed class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Please enter a valid name");
        RuleFor(p => p.Name).NotNull().WithMessage("Please enter a valid name");
        RuleFor(p => p.Name).MinimumLength(3).WithMessage("The name field must be at least 3 characters long");
        RuleFor(p => p.LastName).NotEmpty().WithMessage("Please enter a valid last name");
        RuleFor(p => p.LastName).NotNull().WithMessage("Please enter a valid last name");
        RuleFor(p => p.LastName).MinimumLength(3).WithMessage("The last name must be at least 3 characters long");
        RuleFor(p => p.Username).NotEmpty().WithMessage("Please enter a valid username");
        RuleFor(p => p.Username).NotNull().WithMessage("Please enter a valid username");
        RuleFor(p => p.Username).MinimumLength(3).WithMessage("The username field must be at least 3 characters long");
        RuleFor(p => p.Email).NotEmpty().WithMessage("Please enter a valid email address");
        RuleFor(p => p.Email).NotNull().WithMessage("Please enter a valid email address");
        RuleFor(p => p.Email).EmailAddress().WithMessage("Please enter a valid email address");
        RuleFor(p => p.Email).MinimumLength(3).WithMessage("The email address field must be at least 3 characters long");
        RuleFor(p => p.Password).NotEmpty().WithMessage("Please enter a valid password");
        RuleFor(p => p.Password).NotNull().WithMessage("Please enter a valid password");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Your password must contain at least 1 uppercase letter");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Your password must contain at least 1 lowercase letter");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Your password must contain at least 1 digit");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Your password must contain at least 1 special character");        
    }
}
