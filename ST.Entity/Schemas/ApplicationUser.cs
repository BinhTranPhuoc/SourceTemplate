using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ST.Entity.Schemas
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles {get; set;}
    }
}