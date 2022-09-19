using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Identity
{
    public class DoesNotContainPasswordValidator<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            var username = await manager.GetUserNameAsync(user);
            if (password.Contains(username, StringComparison.OrdinalIgnoreCase))
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "PasswordContainsUsername",
                    Description = "A senha não pode ser igual ao nome de usuário"
                });
            }
            return IdentityResult.Success;
        }
    }
}








