using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagementSystem.Data.Entities;

namespace UserManagementSystem.Pages
{
    [Authorize]
    public class PageOneModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        public PageOneModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        public async Task<IActionResult> OnGet(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/Error");

            var user = await _userManager.GetUserAsync(User);
            if (user.BirthDate != null && (DateTime.Now.Year - user.BirthDate.Value.Year) >= 16)
            {
                return Page();
            }
            else
            {
                ModelState.AddModelError(string.Empty, "The page has an age limit.");
                return RedirectToPage(returnUrl);
            }
        }
    }
}
