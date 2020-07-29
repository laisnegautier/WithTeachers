using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace OnlineEducation.Hubs
{
    public class WebRTCHub : Hub
    {
        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("UpdateGroupState", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("UpdateGroupState", $"{Context.ConnectionId} has left the group {groupName}.");
        }
    }
}