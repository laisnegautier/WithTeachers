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
        private readonly ApplicationUserService _applicationUserService;
        private readonly ILogger<LoginModel> _logger;

        public LoginShortModel(ILogger<LoginModel> logger,
            ApplicationUserService applicationUserService)
        {
            _logger = logger;
            _applicationUserService = applicationUserService;
        }

        public async Task<IActionResult> OnGetAsync(string pseudo, string roomId, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            await _applicationUserService.ConnectUserByPseudoAndRoom(pseudo, roomId);

            _logger.LogInformation("User logged in.");
            return LocalRedirect(returnUrl);
        }
    }
}
