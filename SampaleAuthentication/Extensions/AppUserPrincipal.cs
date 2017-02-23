using System.Security.Claims;

namespace SampaleAuthentication.Extensions
{
    public class AppUserPrincipal : ClaimsPrincipal
    {
        public AppUserPrincipal(ClaimsPrincipal principal)
            : base(principal)
        {
        }

        public string Name
        {
            get
            {
                var result = this.FindFirst(ClaimTypes.Name);
                if (result != null)
                    return result.Value;
                else
                    return "";
            }
        }

        public string Country
        {
            get
            {
                var result = this.FindFirst(ClaimTypes.Country);
                if (result != null)
                    return result.Value;
                else
                    return "";
            }
        }
    }
}