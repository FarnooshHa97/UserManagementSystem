using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UserManagementSystem.Data.Entities;

namespace UserManagementSystem.Areas.Identity.Pages.Account
{
    [Authorize]
    public class EditProfileModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<EditProfileModel> _logger;

        public EditProfileModel(
          UserManager<User> userManager,
          ILogger<EditProfileModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "UserName")]
            public string UserName { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Date of Birth")]
            public DateTime? BirthDate { get; set; }
        }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            Input = new InputModel
            {
                Email = user.Email,
                UserName = user.UserName,
                BirthDate = user.BirthDate
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            user.Email = Input.Email;
            user.UserName = Input.UserName;
            user.BirthDate = Input.BirthDate;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }


            StatusMessage = "Your information has been successfully updated.";

            return RedirectToPage();
        }
    }
}
