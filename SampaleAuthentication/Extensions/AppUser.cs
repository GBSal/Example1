using Microsoft.AspNet.Identity.EntityFramework;

namespace SampaleAuthentication.Extensions
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }

        public int Age { get; set; }
    }
}