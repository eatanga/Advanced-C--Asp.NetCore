#pragma checksum "E:\BIS SCHOOL\SUMMER 2020\CIS174Advanced C#.NetCore\Code\AssignmentsAtanga\Areas\MovieList\Views\Movie\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5194131468bdda1eb47940acbfd496de5d5ec30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_MovieList_Views_Movie_Delete), @"mvc.1.0.view", @"/Areas/MovieList/Views/Movie/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5194131468bdda1eb47940acbfd496de5d5ec30", @"/Areas/MovieList/Views/Movie/Delete.cshtml")]
    public class Areas_MovieList_Views_Movie_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssignmentsAtanga.Areas.MovieList.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\BIS SCHOOL\SUMMER 2020\CIS174Advanced C#.NetCore\Code\AssignmentsAtanga\Areas\MovieList\Views\Movie\Delete.cshtml"
  
    ViewBag.Title = "Delete Movie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Confirm Deletion</h2>\r\n<h3>");
#nullable restore
#line 7 "E:\BIS SCHOOL\SUMMER 2020\CIS174Advanced C#.NetCore\Code\AssignmentsAtanga\Areas\MovieList\Views\Movie\Delete.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 7 "E:\BIS SCHOOL\SUMMER 2020\CIS174Advanced C#.NetCore\Code\AssignmentsAtanga\Areas\MovieList\Views\Movie\Delete.cshtml"
            Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h3>

<form asp-action=""Delete"" method=""post"">
    <input type=""hidden"" asp-for=""MovieId"" />

    <button type=""submit"" class=""btn btn-primary"">Delete</button>
    <a asp-controller=""Home"" asp-action=""Index"" class=""btn btn-primary"">Cancel</a>

</form>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssignmentsAtanga.Areas.MovieList.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591