using System;
using Microsoft.AspNetCore.Identity;

namespace Google.Model.Entities
{
    public class AccountRole : IdentityUserRole<Guid>
    {
        public ApplicationRole Role { get; set; }
    }
}