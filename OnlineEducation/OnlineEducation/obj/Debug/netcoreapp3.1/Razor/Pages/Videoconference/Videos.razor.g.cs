#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4083057eb84190d53996b9d04d487b5a73203a1"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineEducation.Pages.Videoconference
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Pages.Videoconference;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using OnlineEducation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class Videos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "connected-users");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<h3>Group state</h3>\r\n        ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "little");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "li");
            __builder.OpenElement(8, "span");
            __builder.AddContent(9, 
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                       Videoconference.CountConnectedMembers

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " persons");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "li");
            __builder.OpenElement(13, "span");
            __builder.AddContent(14, "Password ");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                                 Videoconference.HasPassword ? "needed" : "not needed"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "list-unstyled");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
             foreach (string message in groupMessages)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                ");
            __builder.OpenElement(22, "li");
            __builder.AddContent(23, 
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                     message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 18 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "toolbar-connectivity");
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "ul");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<li><button class=\"btn\"><span class=\"oi oi-monitor\" aria-hidden=\"true\"></span> Share your screen</button></li>\r\n        ");
            __builder.AddMarkupContent(34, "<li><button class=\"btn\"><span class=\"oi oi-camera-slr\" aria-hidden=\"true\"></span> Disable camera</button></li>\r\n        ");
            __builder.AddMarkupContent(35, "<li><button class=\"btn\"><span class=\"oi oi-microphone\" aria-hidden=\"true\"></span> Disable microphone</button></li>\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                                          Disconnect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "<span class=\"oi oi-phone\" aria-hidden=\"true\"></span> Quit the videoconference");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "videos");
            __builder.AddMarkupContent(46, "\r\n\r\n    ");
            __builder.OpenElement(47, "nav");
            __builder.AddAttribute(48, "class", "navbar fixed-bottom navbar-dark bg-dark toolbarSignalR");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.AddMarkupContent(50, "<h3 class=\"navbar-brand\">State</h3>\r\n        ");
            __builder.OpenElement(51, "ul");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "li");
            __builder.AddMarkupContent(54, "User: \r\n");
#nullable restore
#line 37 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                 if (Videoconference.IsHost(currentUser))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                    ");
            __builder.AddMarkupContent(56, "<span>Host</span>\r\n");
#nullable restore
#line 40 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                }
                else if (!Videoconference.IsHost(currentUser) && currentUser.IsAnonymous)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                    ");
            __builder.OpenElement(58, "span");
            __builder.AddContent(59, 
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                           currentUser.Pseudo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, " (anonymous guest)");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                }
                else if (!Videoconference.IsHost(currentUser) && !currentUser.IsAnonymous)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                    ");
            __builder.OpenElement(63, "span");
            __builder.AddContent(64, 
#nullable restore
#line 47 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                           currentUser.Pseudo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, " (registered guest)");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 48 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "li");
            __builder.AddContent(70, "Connection State: ");
            __builder.OpenElement(71, "span");
            __builder.AddContent(72, 
#nullable restore
#line 50 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                                         HubConnection.State

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "li");
            __builder.AddContent(75, "Connection ID: ");
            __builder.OpenElement(76, "span");
            __builder.AddContent(77, 
#nullable restore
#line 51 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
                                      HubConnection.ConnectionId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\Videos.razor"
       
    ApplicationUser currentUser;

    [Parameter]
    public Videoconference Videoconference { get; set; }

    VideoconferenceUser vu;
    SignalRConnection signalRconnection;

    HubConnection HubConnection;
    List<string> groupMessages = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();
        await InitializeHubAsync();
        vu = await VideoconferenceService.AddToRoom(Videoconference, currentUser);

        string userAgent = await JSRuntime.InvokeAsync<string>("getUserAgent");
        signalRconnection = await VideoconferenceService.AddConnectionToJoinTable(vu, HubConnection.ConnectionId, userAgent);
    }

    async Task InitializeHubAsync()
    {
        // Connection creation
        HubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/webRTCHub"))
        .WithAutomaticReconnect()
        .Build();

        HubConnection.On<string>("UpdateGroupState", (message) => { groupMessages.Add(message); StateHasChanged(); });

        // Connection start
        await HubConnection.StartAsync();

        // Put into group
        await HubConnection.SendAsync("AddToGroup", currentUser.UserName, Videoconference.RoomId);
        await HubConnection.SendAsync("MessageToYou", currentUser.UserName, "laisne.gautier@gmail.com", Videoconference.RoomId, "salut putoi");
        await HubConnection.SendAsync("MessageTest", currentUser.UserName, Videoconference.RoomId, "hihihihi");
    }

    async Task Disconnect()
    {
        //needs to:
        //remove from room in the database
        //prevent the others
        //disconnect from hub
        //delete account
        await VideoconferenceService.Disconnect(currentUser, Videoconference);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VideoconferenceService VideoconferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
