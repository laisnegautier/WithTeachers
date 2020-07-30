using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OnlineEducation.Data;
using OnlineEducation.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducation.Hubs
{
    public class WebRTCHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public WebRTCHub(ApplicationDbContext context)
        {
            _context = context;
        }

        public override async Task OnConnectedAsync()
        {
            VideoconferenceUser user = _context.VideoconferenceUsers.SingleOrDefault(u => u.UserName == Context.User.Identity.Name);

            // If user does not exist in database, must add.
            if (user == null)
            {
                user = new VideoconferenceUser()
                {
                    UserName = Context.User.Identity.Name
                };
                _context.VideoconferenceUsers.Add(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                // Add to each assigned group.
                foreach (UserRoom userRoom in user.UserRooms)
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, userRoom.Room.RoomName);
                }
            }

            await base.OnConnectedAsync();
        }

        public async Task AddToRoom(string roomName)
        {
            Room room = _context.Rooms.Find(roomName);

            if (room != null)
            {
                VideoconferenceUser user = new VideoconferenceUser() { UserName = Context.User.Identity.Name };
                _context.VideoconferenceUsers.Attach(user);

                UserRoom userRoom = new UserRoom() { RoomId = room.RoomId, VideoconferenceUserId = user.VideoconferenceUserId };
                _context.UserRooms.Add(userRoom);
                //room.Users.Add(user);
                await _context.SaveChangesAsync();
                await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
            }

            await Clients.Group(roomName).SendAsync("UpdateGroupState", $"{Context.User.Identity.Name}, {Context.ConnectionId} has joined the group {roomName}.");
        }

        public async Task RemoveFromRoom(string roomName)
        {
            Room room = _context.Rooms.Find(roomName);

            if (room != null)
            {
                VideoconferenceUser user = new VideoconferenceUser() { UserName = Context.User.Identity.Name };
                _context.VideoconferenceUsers.Attach(user);

                UserRoom userRoom = await _context.UserRooms.SingleOrDefaultAsync(x => x.RoomId == room.RoomId && x.VideoconferenceUserId == user.VideoconferenceUserId);
                _context.UserRooms.Remove(userRoom);

                await _context.SaveChangesAsync();
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
            }

            await Clients.Group(roomName).SendAsync("UpdateGroupState", $"{Context.User.Identity.Name}, {Context.ConnectionId} has left the group {roomName}.");
        }
    }
}