using Microsoft.AspNetCore.Identity;

namespace Between.Server.App.Areas.Identity.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}
