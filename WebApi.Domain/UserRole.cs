using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Domain
{
    internal class UserRole : IdentityUserRole
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }   
}
