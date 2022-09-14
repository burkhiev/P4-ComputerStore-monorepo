using Microsoft.AspNetCore.Identity;
using NodaTime;

namespace FNS.Domain.Models.Identity
{
    public class Role : IdentityRole, IEntityBase
    {
        public Role() : base()
        {
            // nothing
        }

        public Role(string name) : base(name)
        {
            // nothing
        }

        public uint xmin { get; set; }

        public Instant CreatedAt { get; set; }

        public Instant UpdatedAt { get; set; }

        public virtual List<IdentityUserRole<string>>? UserRoles { get; set; }
    }
}
