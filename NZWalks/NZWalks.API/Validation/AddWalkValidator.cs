using FluentValidation;

namespace NZWalks.API.Validation
{
    public class AddWalkValidator:AbstractValidator<Models.DTO.AddWalkRequest>
    {
        public AddWalkValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Length).GreaterThanOrEqualTo(0);
        }
    }
}
