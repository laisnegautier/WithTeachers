using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using OnlineEducation.Data.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace OnlineEducation.Data.Services
{
    public class ApplicationUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly VideoconferenceService VideoconferenceService;

        public ApplicationUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AuthenticationStateProvider authenticationStateProvider, VideoconferenceService videoconferenceService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authenticationStateProvider = authenticationStateProvider;
            VideoconferenceService = videoconferenceService;
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
        /// Get the user who has the same pseudo in the videoconference associated with the roomId. Returns null if nothing is found.
        /// </summary>
        /// <param name="pseudo"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetByPseudoAndRoom(string pseudo, string roomId)
        {
            Videoconference vc = await VideoconferenceService.GetByRoomAsync(roomId);

            foreach (VideoconferenceUser vcUser in vc.VideoconferenceUsers)
                if (vcUser.User.Pseudo == pseudo)
                    return vcUser.User;

            return null;
        }

        /// <summary>
        /// Return the user asked by name and connect him directly. Create a user if needed.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task ConnectUserByPseudoAndRoom(string pseudo, string roomId)
        {
            Videoconference vc = await VideoconferenceService.GetByRoomAsync(roomId);

            if(vc != null)
            {
                ApplicationUser user = await GetByPseudoAndRoom(pseudo, roomId);

                if (user != null)
                {
                    await _signInManager.SignInAsync(user, true);
                }
                else
                {
                    await CreateUserByPseudoAsync(pseudo);
                }
            }
        }

        private async Task CreateUserByPseudoAsync(string pseudo)
        {
            ApplicationUser user = new ApplicationUser
            {
                UserName = Guid.NewGuid().ToString(),
                Email = null,
                Pseudo = pseudo,
                IsAnonymous = true,
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