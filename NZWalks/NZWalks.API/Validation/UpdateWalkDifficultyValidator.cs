using FluentValidation;

namespace NZWalks.API.Validation
{
    public class UpdateWalkDifficultyValidator:AbstractValidator<Models.DTO.UpdateWalkDifficultyRequest>
    {
        public UpdateWalkDifficultyValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
