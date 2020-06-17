#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c58f8f54d93db3d243261faedcda831b2cb29c"
// <auto-generated/>
#pragma warning disable 1591
namespace WithTeachers.Pages.Scheduler
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
using WithTeachers.Data;

#line default
#line hidden
#nullable disable
    public partial class Matrix : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
   int x; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
 for (int y = 0; y < SizeY; y++)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "tr");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<WithTeachers.Pages.Scheduler.HourCell>(3);
            __builder.AddAttribute(4, "Hour", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 8 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
                         HandleDateTime(y)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
           x = 1; int spanY = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
         foreach (DateTime day in Week)
        {
            spanY = HandleSpanY(x, y);


#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenComponent<WithTeachers.Pages.Scheduler.Cell>(7);
            __builder.AddAttribute(8, "SpanY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
                          spanY

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "IsDisplayable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
                                                 HandleDisplay(x, y)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "IsResizable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Day", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 15 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
                                                                                               HandleDateTime(y, day)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 16 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
            x++;
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 19 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Matrix.razor"
       
    [Parameter]
    public Week Week { get; set; }

    [Parameter]
    public int SizeX { get; set; }

    [Parameter]
    public int SizeY { get; set; }

    private bool HandleDisplay(int x, int y)
    {
        // First column
        if (x == 0)
            // We don't want :30 minutes on the first column
            return y % 2 == 0;
        // This else has to be completed when sizable cell will be implemented
        else
            return true;
    }

    private int HandleSpanY(int x, int y)
    {
        return x == 0 ? (y % 2 == 0 ? 2 : 1) : 1;
    }

    internal struct HourMinute
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public HourMinute(int y)
        {
            if (y % 2 == 0)
            {
                Hour = y / 2;
                Minute = 0;
            }
            else
            {
                Hour = (y - 1) / 2;
                Minute = 30;
            }
        }
    }

    private DateTime HandleDateTime(int y, DateTime day)
    {
        HourMinute hourMinute = new HourMinute(y);

        return new DateTime(day.Year, day.Month, day.Day, hourMinute.Hour, hourMinute.Minute, 0);
    }

    private DateTime HandleDateTime(int y)
    {
        HourMinute hourMinute = new HourMinute(y);

        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hourMinute.Hour, hourMinute.Minute, 0);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
