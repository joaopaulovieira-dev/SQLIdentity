﻿using System;

namespace WebApi.Domain
{
    public class User : IdentityUser
    {
        public string NomeCompleto { get; set; }

        public string Member { get; set; } = "Member";
        public string OrgId { get; set; }
    }
}
