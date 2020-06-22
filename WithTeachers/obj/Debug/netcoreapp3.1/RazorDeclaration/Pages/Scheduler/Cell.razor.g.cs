#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Cell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8078229c0fb47055d47f4b4904ab746b4f57998f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Cell.razor"
using WithTeachers.Data;

#line default
#line hidden
#nullable disable
    public partial class Cell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Scheduler\Cell.razor"
       
    [Parameter]
    public int[,] SpanMatrix { get; set; }

    [Parameter]
    public int X { get; set; }

    [Parameter]
    public int Y { get; set; }

    [Parameter]
    public bool IsResizable { get; set; }

    [Parameter]
    public DateTime Day { get; set; }

    [Parameter]
    public string CellClass { get; set; }

    [Parameter]
    public Activity Activity { get; set; }

    [Parameter]
    public EventCallback<Tuple<Activity, int, int>> OnDragActivity { get; set; }
    [Parameter]
    public EventCallback<int[]> OnDropCoordinates { get; set; }

    private string dragClass = "";

    private async Task HandleDragStart(Activity selectedActivity, int startX, int startY)
    {
        dragClass = "border: 2px dashed blue !important;";
        await OnDragActivity.InvokeAsync(new Tuple<Activity, int, int>(selectedActivity, startX, startY));
    }

    private async Task HandleDrop(int x, int y)
    {
        await OnDropCoordinates.InvokeAsync(new int[] { x, y });
        dragClass = "border: 2px dashed cyan !important;";
    }

    private void HandleDrag(DragEventArgs e)
    {
        dragClass = "border: 2px dashed green !important;";
    }

    private void HandleDragEnter(DragEventArgs e)
    {
        dragClass = "border: 2px dashed pink !important;";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
