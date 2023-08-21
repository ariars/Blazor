using Between.Server.App.Areas.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Between.Server.App.Pages.Candidates.CandidatesIncomes
{
    public class ManageTestModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public string UserId { get; set; }

        public ManageTestModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            UserId = await _userManager.GetUserIdAsync(user);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }
    }
}
