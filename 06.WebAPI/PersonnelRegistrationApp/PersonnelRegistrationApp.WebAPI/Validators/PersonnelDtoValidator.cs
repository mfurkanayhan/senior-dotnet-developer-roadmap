using FluentValidation;
using PersonnelRegistrationApp.WebAPI.DTOs;

namespace PersonnelRegistrationApp.WebAPI.Validators;

public class PersonnelDtoValidator : AbstractValidator<PersonnelDto>
{
    public PersonnelDtoValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty().MinimumLength(3);
        RuleFor(p => p.LastName).NotEmpty().MinimumLength(3);
        RuleFor(p => p.Email).NotEmpty().WithMessage("Email address cannot be empty.")
                                 .MinimumLength(3).WithMessage("Email address must be at least 3 characters.")
                                 .EmailAddress().WithMessage("Enter a valid email address.");
    }
}
