using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using OnlineEducation.Data.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineEducation.Data.Services
{
    public class ApplicationUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ApplicationUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<ApplicationUser> GetCurrentUser()
        {
            ClaimsPrincipal User = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;
            return await _userManager.GetUserAsync(User);
        }

        public async Task<ClaimsPrincipal> GetUserClaim()
            => (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;


        public async Task<ApplicationUser> GetUserByName(string userName)
            => await _userManager.FindByNameAsync(userName);

        /// <summary>
        /// Return the user asked by name and connect him directly. Create a user if needed.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> ConnectUserByName(string userName)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(userName);

            if (user != null)
            {
                await _signInManager.SignInAsync(user, true);
            }
            else
            {
                await CreateUserAsync(userName);
            }

            return user;
        }

        private async Task CreateUserAsync(string userName)
        {
            ApplicationUser user = new ApplicationUser 
            { 
                UserName = userName, 
                Email = null, 
                EmailConfirmed = true 
            };

            IdentityResult result = await _userManager.CreateAsync(user); // Create without password.
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, true);
            }
        }
    }
}