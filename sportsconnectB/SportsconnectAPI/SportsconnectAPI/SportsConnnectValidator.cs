using FluentValidation;
using SportsconnectAPI.Models;

namespace SportsconnectAPI

{
    public class SportsConnnectValidator : AbstractValidator<Player>
    {
        public SportsConnnectValidator()
        {
            RuleFor(t => t.name).NotNull().NotEmpty().MaximumLength(57);
            RuleFor(t => t.age).NotNull().NotEmpty().LessThan(157).GreaterThan(5);
            RuleFor(t => t.phone).NotNull().NotEmpty().MaximumLength(57);
            RuleFor(t => t.address).NotNull().NotEmpty().MaximumLength(95);
            RuleFor(t => t.sport).NotNull().NotEmpty().MaximumLength(38);
            RuleFor(t => t.pCode).NotNull().NotEmpty().GreaterThanOrEqualTo(0);
        }
    }

    public class EventValidator : AbstractValidator<Event>
    {
        public EventValidator()
        {
            RuleFor(t => t.title).NotNull().NotEmpty().MaximumLength(95);
            RuleFor(t => t.duration).NotNull().NotEmpty().LessThan(19);
            RuleFor(t => t.owner).NotNull().NotEmpty().MaximumLength(190);
            RuleFor(t => t.location).NotNull().NotEmpty().MaximumLength(95);
            RuleFor(t => t.sport).NotNull().NotEmpty().MaximumLength(38);
            RuleFor(t => t.pCode).NotNull().NotEmpty().GreaterThanOrEqualTo(0);
        }
    }
}
