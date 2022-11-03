using FluentValidation;

namespace NZWalks.API.Validation
{
    public class AddWalkDifficultyValidator : AbstractValidator<Models.DTO.AddWalkDifficultyRequest>
    {
        public AddWalkDifficultyValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
