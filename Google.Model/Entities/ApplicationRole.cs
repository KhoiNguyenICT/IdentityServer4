using System;
using Microsoft.AspNetCore.Identity;

namespace Google.Model.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}