using EPlatform.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlatform.WebUI.Infrastructure
{
    public class CustomPasswordValidator : IPasswordValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();

            if (password.ToLower().Contains(user.UserFirstName.ToLower()) || password.ToLower().Contains(user.UserFirstName.ToLower()))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsUserName",
                    Description = "Password cannot contain user name"
                });
            }

            if (password.Contains("123"))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsNumericSequence",
                    Description = "Password cannot contain numeric sequence"
                });
            }


            return Task.FromResult(errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }

}
