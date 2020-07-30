using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OnlineEducation.Data.Models;
using OnlineEducation.Data.Services;

namespace OnlineEducation.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginShortModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationUserService _applicationUserService;
        private readonly ILogger<LoginModel> _logger;

        public LoginShortModel(SignInManager<ApplicationUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser> userManager,
            ApplicationUserService applicationUserService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _applicationUserService = applicationUserService;
        }

        public async Task<IActionResult> OnGetAsync(string userName, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            await _applicationUserService.ConnectUserByName(userName);


            _logger.LogInformation("User logged in.");
            return LocalRedirect(returnUrl);
        }
    }
}
