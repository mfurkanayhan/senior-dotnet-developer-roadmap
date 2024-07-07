using eHospitalServer.Entities.DTOs;
using FluentValidation;

namespace eHospitalServer.Business.Validators;
public sealed class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
{
    public CreateUserDtoValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty().WithMessage("Name field cannot be empty.");
        RuleFor(p => p.FirstName).NotNull().WithMessage("Name field cannot be empty.");
        RuleFor(p => p.FirstName).MinimumLength(3).WithMessage("The name field must be at least 3 characters long.");
    }
}