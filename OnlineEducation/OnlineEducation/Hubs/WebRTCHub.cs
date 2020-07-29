using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducation.Hubs
{
    //Using a strongly typed Hub<T> disables the ability to use SendAsync.
    //Here "Clients.All.name_of_methode(param1, param2, ...)" is the same as "Clients.All.SendAsync("name_of_method", param1, param2, ...)"
    //More infos: https://docs.microsoft.com/en-us/aspnet/core/signalr/hubs?view=aspnetcore-3.1
    public interface IWebRTCHub
    {
        Task TestCallerClient(string message);
    }

    public class WebRTCHub : Hub<IWebRTCHub>
    {
        public async Task TestCaller()
        {
            string ok = "ok CALLER";
            await Clients.Caller.TestCallerClient(ok);
        }
    }
}
