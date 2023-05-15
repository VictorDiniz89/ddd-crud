using Domain.Entities;
using FluentValidation;

namespace Infrastructure.Validators
{
    /// <summary>
    /// Validates properties of a User object.
    /// </summary>
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();

            RuleFor(x => x.title)
                .NotNull()
                .WithMessage("Title is required")
                .Length(1, 30);

            RuleFor(x => x.firstName)
                .NotNull()
                .WithMessage("First Name is required")
                .Length(1, 30);

            RuleFor(x => x.lastName)
                .NotNull()
                .WithMessage("Last Name is required")
                .Length(1, 30);

            RuleFor(x => x.email)
                .NotNull()
                .NotEmpty()
                .WithMessage("Email address is required")
                .EmailAddress().WithMessage("A valid email is required")
                .Length(1, 80);

            RuleFor(x => x.role)
                .NotNull()
                .WithMessage("Role is required")
                .Length(1, 30);
        }
    }

}
