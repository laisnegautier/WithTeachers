#pragma checksum "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11a4b6098675f79cb66e9981ed399ddf90369815"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WithTeachers.Pages.Courses
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
#line 2 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
using WithTeachers.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
using WithTeachers.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
using Slugify;

#line default
#line hidden
#nullable disable
    public partial class AddCourseForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Gautier\source\repos\KarmaFlights\WithTeachers\WithTeachers\Pages\Courses\AddCourseForm.razor"
       
    ApplicationUser currentUser;
    CourseCourseDocument model = new CourseCourseDocument();
    SlugHelper slugHelper = new SlugHelper();

    [Parameter]
    public EventCallback<string> OnSubmitValidated { get; set; }

    protected override async void OnInitialized()
    {
        currentUser = await ApplicationUserService.GetCurrentUser();
    }

    private async Task HandleValidSubmitAddCourse()
    {
        // Course
        model.Course.Slug = slugHelper.GenerateSlug(model.Course.Title);
        model.Course.CreationDate = DateTime.Now;
        model.Course.UpdateDate = DateTime.Now;
        model.Course.User = currentUser;

        await CourseService.CreateAsync(model.Course);

        // CourseDocument
        model.CourseDocument.FileUrl = "test";
        model.CourseDocument.UploadDate = DateTime.Now;
        model.CourseDocument.Course = model.Course;

        await CourseDocumentService.CreateAsync(model.CourseDocument);

        // Reset
        model = new CourseCourseDocument();

        // Notifier
        await OnSubmitValidated.InvokeAsync("The course <strong>" + model.Course.Title + "</strong> has been added to your courses!");
    }

    private string fileStatus;

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            await FileUploadService.UploadAsync(file);

            fileStatus = $"Finished loading {file.Size} bytes from {file.Name}";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUploadService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseDocumentService CourseDocumentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CourseService CourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationUserService ApplicationUserService { get; set; }
    }
}
#pragma warning restore 1591
