using Microsoft.AspNet.Identity.EntityFramework;

namespace SampaleAuthentication.Extensions
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }
    }
}