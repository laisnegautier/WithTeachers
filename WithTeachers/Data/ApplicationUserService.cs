using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class ApplicationUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public ApplicationUserService(UserManager<ApplicationUser> userManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _userManager = userManager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<ApplicationUser> GetCurrentUser()
        {
            ClaimsPrincipal User = (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;
            return await _userManager.GetUserAsync(User);
        }

        public async Task<ClaimsPrincipal> GetUserClaim()
            => (await _authenticationStateProvider.GetAuthenticationStateAsync()).User;
    }
}