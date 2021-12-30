using FluentValidation;
using ServiceClient.Infrastructure.Models.Api.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Validation
{
    
    public class RegistrationRequestValidator : AbstractValidator<RegistrationRequest>
    {
        public RegistrationRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.PasswordHash).NotEmpty();
        }
    }
}
