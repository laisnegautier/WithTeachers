using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OnlineEducation.Data;
using OnlineEducation.Data.Models;
using OnlineEducation.Data.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducation.Hubs
{
    public class WebRTCHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly ApplicationUserService _applicationUserService;
        private readonly VideoconferenceService _videoconferenceService;

        public WebRTCHub(ApplicationDbContext context, ApplicationUserService applicationUserService, VideoconferenceService videoconferenceService)
        {
            _context = context;
            _applicationUserService = applicationUserService;
            _videoconferenceService = videoconferenceService;
        }

        public override async Task OnConnectedAsync()
        {
            //VideoconferenceUser user = _context.VideoconferenceUsers.SingleOrDefault(u => u.UserName == Context.User.Identity.Name);

            //foreach (VideoconferenceUser userRoom in user.)
            //{
            //    await Groups.AddToGroupAsync(Context.ConnectionId, userRoom.Room.RoomName);
            //}

            await base.OnConnectedAsync();
        }

        public async Task AddToGroup(string userPseudo, string roomId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
            await Clients.Group(roomId).SendAsync("MessageToGroupClient", $"{userPseudo} joined the room.");

        }

        public async Task GetNumberOfUsers(string roomId)
        {
            int nb = await _videoconferenceService.GetNumberOfConnectedUserInRoom(roomId);
            await Clients.Group(roomId).SendAsync("UpdateNumberOfConnectedUser", nb);
        }
        
        public async Task MessageToGroup(string message, string roomId)
            => await Clients.Group(roomId).SendAsync("MessageToGroupClient", message);

        public async Task RemoveFromRoom(string roomName)
        {
            //Room room = await _context.Rooms.SingleOrDefaultAsync(x => x.RoomName == roomName);

            //if (room != null)
            //{
            //    VideoconferenceUser user = new VideoconferenceUser() { UserName = Context.User.Identity.Name };
            //    _context.VideoconferenceUsers.Attach(user);

            //    UserRoom userRoom = await _context.UserRooms.SingleOrDefaultAsync(x => x.RoomId == room.RoomId && x.VideoconferenceUserId == user.VideoconferenceUserId);
            //    _context.UserRooms.Remove(userRoom);

            //    await _context.SaveChangesAsync();
            //    await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
            //}

            await Clients.Group(roomName).SendAsync("MessageToGroup", $"{Context.User.Identity.Name}, {Context.ConnectionId} has left the group {roomName}.");
        }

        public async Task DisconnectAsync(string userPseudo, string roomId)
        {
            await Clients.Group(roomId).SendAsync("MessageToGroupClient", $"{userPseudo} left the room.");

            //abort the current connexion
            Context.Abort();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {

            await base.OnDisconnectedAsync(exception);
        }
    }
}