#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5e7739d9723c1eae97c6ab82f02a101d1b9c26b"
// <auto-generated/>
#pragma warning disable 1591
namespace WithTeachers.Pages.Scheduler
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using WithTeachers.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
using WithTeachers.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/scheduler")]
    public partial class Scheduler : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Scheduler</h3>\r\n\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "scheduler");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-4");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "date");
            __builder.AddAttribute(9, "class", "form-control datePicker");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                                                       SelectedDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedDate = __value, SelectedDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group col-4");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "button-week");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                                  PreviousWeek

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "‹ Previous week");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "button-week");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                                  NextWeek

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Next week ›");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n            ");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "table table-bordered");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "thead");
            __builder.AddAttribute(32, "class", "thead-dark");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n                        <th></th>\r\n                        ");
            __builder.OpenComponent<WithTeachers.Pages.Scheduler.DaysHeading>(36);
            __builder.AddAttribute(37, "Week", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WithTeachers.Data.Week>(
#nullable restore
#line 25 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                            Week

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenComponent<WithTeachers.Pages.Scheduler.Matrix>(43);
            __builder.AddAttribute(44, "Week", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WithTeachers.Data.Week>(
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                   Week

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "SizeX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                                8

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "SizeY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
                                                          48

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Scheduler.razor"
       
    private static DateTime _selectedDate = DateTime.Now;
    private static DateTime SelectedDate
    {
        get => _selectedDate;
        set {
            _selectedDate = value;
            Week = new Week(value);
        }
    }

    private static Week Week = new Week(SelectedDate);

    private void NextWeek() => SelectedDate = SelectedDate.AddDays(7).StartOfWeek(DayOfWeek.Monday);
    private void PreviousWeek() => SelectedDate = SelectedDate.AddDays(-7).StartOfWeek(DayOfWeek.Monday);

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
#pragma warning restore 1591
