using Microsoft.AspNetCore.Identity;

namespace FNS.Domain.Models.Identity
{
    public class Role : IdentityRole
    {
        public Role() : base()
        {
            // nothing
        }

        public Role(string name) : base(name)
        {
            // nothing
        }

        public virtual List<IdentityUserRole<string>>? UserRoles { get; set; }
    }
}
