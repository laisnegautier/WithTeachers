using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace WithTeachers.Hubs
{
    // Client API:
    //
    // updateUserList(List<User> userList)
    // callAccepted(User acceptingUser)
    // callDeclined(User decliningUser, string reason)
    // incomingCall(User callingUser)
    // receiveSignal(User signalingUser, string signal)

    //Using a strongly typed Hub<T> disables the ability to use SendAsync.
    //Here "Clients.All.name_of_methode(param1, param2, ...)" is the same as "Clients.All.SendAsync("name_of_method", param1, param2, ...)"
    //More infos: https://docs.microsoft.com/en-us/aspnet/core/signalr/hubs?view=aspnetcore-3.1
    public interface IWebRtcHub
    {
        Task TestConnectionClient();

        Task TestCallerClient(string message);

        Task JoinRoom(string connectionId);

        Task LeaveRoom(string connectionId);
    }

    public class WebRtcHub : Hub<IWebRtcHub>
    {
        public async Task TestConnection(string str1, string str2)
        {
            await Clients.All.TestConnectionClient();
        }

        public async Task TestCaller()
        {
            string ok = "ok CALLER";
            await Clients.Caller.TestCallerClient(ok);
        }

        public async Task InsertRoom(string roomId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId);
            await Clients.Group(roomId).JoinRoom(Context.ConnectionId);
        }

        public async Task RemoveFromRoom(string roomId)
        {
            await Clients.Group(roomId).LeaveRoom(Context.ConnectionId);
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId);
        }
    }
}