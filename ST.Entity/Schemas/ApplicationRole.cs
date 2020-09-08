using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ST.Entity.Schemas
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}