using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OnlineEducation.Data;
using OnlineEducation.Data.Models;
using OnlineEducation.Data.Services;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducation.Hubs
{
    public class NameUserIdProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
        {
            return connection.User?.Identity?.Name;
        }
    }

    public class WebRTCHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly ApplicationUserService _applicationUserService;

        public WebRTCHub(ApplicationDbContext context, ApplicationUserService applicationUserService)
        {
            _context = context;
            _applicationUserService = applicationUserService;
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

        //public async Task AddToRoom(string userName, string roomName)
        //{
        //    Room room = await _context.Rooms.SingleOrDefaultAsync(x => x.RoomName == roomName);

        //    if (room != null)
        //    {
        //        VideoconferenceUser user = await _applicationUserService.GetUserByName(userName);
        //        _context.VideoconferenceUsers.Attach(user);

        //        UserRoom userRoom = new UserRoom() { RoomId = room.RoomId, VideoconferenceUserId = user.VideoconferenceUserId };
        //        _context.UserRooms.Add(userRoom);
        //        //room.Users.Add(user);
        //        await _context.SaveChangesAsync();
        //        await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        //    }

        //    await Clients.All.SendAsync("UpdateGroupState", $"{Context.User.Identity.Name}, {Context.ConnectionId} has joined the group {roomName}.");

        //    await Clients.Group(roomName).SendAsync("UpdateGroupState", $"{Context.User.Identity.Name}, {Context.ConnectionId} has joined the group {roomName}.");
        //}

        public Task AddToGroup(string user, string roomId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, roomId);
        }

        public Task MessageTest(string user, string roomId, string message)
        {
            return Clients.Group(roomId).SendAsync("UpdateGroupState", $"{user} said: {message}, {Context.ConnectionId}, {Context.UserIdentifier}, {Context.User.Identity.IsAuthenticated}");
        }


        public async Task MessageToYou(string userA, string userB, string roomId, string message)
        {
            //VideoconferenceUser userReceiver = await _video.GetUserByName(userB);
            //foreach(string connectionId in userReceiver.UserRoom)
            //await Clients.Client(userReceiver.Id).SendAsync("UpdateGroupState", $"{userA} said to yo: {message}, {Context.ConnectionId}, {Context.UserIdentifier}, {Context.User.Identity.IsAuthenticated}");
        }

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

            await Clients.Group(roomName).SendAsync("UpdateGroupState", $"{Context.User.Identity.Name}, {Context.ConnectionId} has left the group {roomName}.");
        }
    }
}