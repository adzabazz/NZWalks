using FluentValidation;

namespace NZWalks.API.Validation
{
    public class LoginValidator : AbstractValidator<Models.DTO.LoginRequest> 
    {
        public LoginValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
