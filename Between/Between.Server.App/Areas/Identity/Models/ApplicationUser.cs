using Microsoft.AspNetCore.Identity;

namespace Between.Server.App.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Timezone { get; set; }
    }
}
