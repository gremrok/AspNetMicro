using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands
{
    public class DeleteOrderValidator: AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderValidator()
        {
            RuleFor(p => p.Id)
                .GreaterThan(0)
                .WithMessage("{Id} must be greeter then zero");

        }
    }
}
