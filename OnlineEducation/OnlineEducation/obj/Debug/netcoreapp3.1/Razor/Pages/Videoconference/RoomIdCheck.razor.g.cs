#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb3cfb313ec461ccb6bce9815134dd42faf0c1e5"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Videoboard))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{RoomId}")]
    public partial class RoomIdCheck : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 25 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
 if (userHasJoinedRoom)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<OnlineEducation.Pages.Videoconference.Videos>(1);
            __builder.AddAttribute(2, "RoomId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                     RoomId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 28 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "centered-div");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 32 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
     if (!videoconferenceExists(RoomId))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.AddMarkupContent(8, "<h1>Page not found</h1>\r\n        ");
            __builder.AddMarkupContent(9, "<p>There is nothing associated with the URL.</p>\r\n        ");
            __builder.AddMarkupContent(10, "<button class=\"btn\">Go to home page</button>\r\n");
#nullable restore
#line 37 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "h1");
            __builder.OpenElement(13, "strong");
            __builder.AddContent(14, 
#nullable restore
#line 40 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                     videoconference.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(15, " videoconference");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "list-unstyled");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "li");
            __builder.AddContent(21, "Hosted by ");
            __builder.OpenElement(22, "strong");
            __builder.AddContent(23, 
#nullable restore
#line 42 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                   videoconference.User.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "li");
            __builder.AddContent(26, "Scheduled for ");
            __builder.OpenElement(27, "strong");
            __builder.AddContent(28, 
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                       videoconference.ScheduledFor.ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, ", ");
            __builder.AddContent(30, 
#nullable restore
#line 43 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                          videoconference.ScheduledFor.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "li");
            __builder.AddContent(33, "Length: ");
            __builder.AddContent(34, 
#nullable restore
#line 44 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                         videoconference.TimeSpan.ToString(@"hh\:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "li");
            __builder.AddContent(37, "Description: ");
            __builder.AddContent(38, 
#nullable restore
#line 45 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                              videoconference.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 49 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
         if (videoconference.IsHost(currentUser))
        {
            //c4
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
             if (videoconference.IsOngoing)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                              JoinVideoconference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Start the videoconference");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 55 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                              StartVideoconference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Start the videoconference");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 59 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                 
        }
        else
        {
            //c5
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
             if (videoconference.IsCompleted)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<div class=\"alert alert-info\"><p>This videoconference has <strong>finished</strong>.</p></div> ");
#nullable restore
#line 65 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                            }
            else if (videoconference.HasToOccurLater)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, " ");
            __builder.AddMarkupContent(55, "<div class=\"alert alert-info\"><p>This videoconference has <strong>not begun yet</strong>.</p></div> ");
#nullable restore
#line 67 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                                  }
            else if (videoconference.IsOngoing)
            {
                //c6
                if (videoconference.HasPassword && !videoconference.PasswordIsCorrect(inputVideoconferencePassword))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.AddMarkupContent(57, "<div class=\"alert alert-info mb-3\">\r\n                        <p>A <strong>password</strong> is needed to access the videoconference.</p>\r\n                    </div>\r\n");
            __builder.AddContent(58, "                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-inline");
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "password");
            __builder.AddAttribute(64, "class", "form-control text-center mb-3 mb-sm-0 mr-2");
            __builder.AddAttribute(65, "placeholder", "Enter the password to join");
            __builder.AddAttribute(66, "autofocus", true);
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                         inputVideoconferencePassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputVideoconferencePassword = __value, inputVideoconferencePassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.AddMarkupContent(70, "<button class=\"btn\">Submit</button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 81 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                }
                else
                {
                    //c7
                    //here it's just another user of the platform but not the one who created the videoconf so we don't ask for other name
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                     if (currentUser != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "                        ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                      JoinVideoconference

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Join as ");
            __builder.AddContent(77, 
#nullable restore
#line 88 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                    currentUser.Pseudo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 89 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-inline");
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "class", "form-control text-center mb-3 mb-sm-0 mr-2");
            __builder.AddAttribute(86, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                            InputPseudo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "placeholder", "Write your name");
            __builder.AddAttribute(88, "autofocus", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "a");
            __builder.AddAttribute(91, "href", "Identity/Account/LoginShort?pseudo=" + (
#nullable restore
#line 94 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                         inputPseudo

#line default
#line hidden
#nullable disable
            ) + "&roomId=" + (
#nullable restore
#line 94 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                             RoomId

#line default
#line hidden
#nullable disable
            ) + "&returnUrl=/" + (
#nullable restore
#line 94 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                                                                                                                RoomId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "class", "mr-3");
            __builder.AddContent(93, "JoinTest");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 97 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                         if (!String.IsNullOrEmpty(inputPseudo))
                        {
                            if (pseudoExistsInTheRoom)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                                ");
            __builder.AddMarkupContent(97, "<p class=\"small\">This user name is already taken for this videoconference.</p>\r\n");
#nullable restore
#line 102 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
                     
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
         
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 110 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\OnlineEducation\OnlineEducation\Pages\Videoconference\RoomIdCheck.razor"
       
    [Parameter]
    public string RoomId { get; set; }

    ApplicationUser currentUser;
    Videoconference videoconference;
    string inputVideoconferencePassword;

    string inputPseudo;
    bool pseudoExistsInTheRoom;
    bool userHasJoinedRoom;

    ApplicationUser userJoiningTheVideoconference; //can be the host, a connected guest or an anonymous guest

    protected override async Task OnInitializedAsync()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();

        if (!String.IsNullOrEmpty(RoomId))
            videoconference = await VideoconferenceService.GetByRoomAsync(RoomId);
    }

    private bool videoconferenceExists(string roomId)
        => videoconference != null;

    private async Task JoinVideoconference()
    {
        //await VideoconferenceService.AddToRoom(videoconference, currentUser);
        userHasJoinedRoom = true;
    }

    private async Task StartVideoconference()
    {
        videoconference.IsOngoing = true;
        await VideoconferenceService.UpdateAsync(videoconference);

        await JoinVideoconference();
    }

    private async Task InputPseudo(ChangeEventArgs args)
    {
        inputPseudo = args.Value.ToString();
        await PseudoExistsInTheRoomAsync(inputPseudo, RoomId);
    }

    private async Task PseudoExistsInTheRoomAsync(string pseudo, string roomId)
    {
        ApplicationUser userWithSamePseudoInTheSameRoom = await ApplicationUserService.GetByPseudoAndRoom(pseudo, roomId);
        pseudoExistsInTheRoom = userWithSamePseudoInTheSameRoom != null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VideoconferenceService VideoconferenceService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
#pragma warning restore 1591
