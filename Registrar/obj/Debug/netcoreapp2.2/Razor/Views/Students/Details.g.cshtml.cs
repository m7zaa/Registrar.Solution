#pragma checksum "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b78b575f552b7fe7c5404aa947fb109557dad4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b78b575f552b7fe7c5404aa947fb109557dad4c", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 37, true);
            WriteLiteral("\n<h2>Student Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(98, 47, false);
#line 9 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(145, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(148, 43, false);
#line 9 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(191, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 11 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
 if(@Model.Courses.Count == 0)
{

#line default
#line hidden
            BeginContext(231, 53, true);
            WriteLiteral("  <p>This student does not belong to any courses</p>\n");
            EndContext();
#line 14 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(293, 50, true);
            WriteLiteral("  <h4>Courses the student belongs to:</h4>\n  <ul>\n");
            EndContext();
#line 19 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
   foreach(var join in Model.Courses)
  {

#line default
#line hidden
            BeginContext(385, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(394, 22, false);
#line 21 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
   Write(join.Course.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(416, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 22 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
     using (Html.BeginForm("DeleteCourse", "Students"))
    {
      

#line default
#line hidden
            BeginContext(491, 44, false);
#line 24 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
 Write(Html.Hidden("joinId", @join.CourseStudentId));

#line default
#line hidden
            EndContext();
            BeginContext(536, 44, true);
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\n");
            EndContext();
#line 26 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
    }

#line default
#line hidden
#line 26 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(590, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 29 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
}

#line default
#line hidden
            BeginContext(600, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(605, 43, false);
#line 31 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Back to Student", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(648, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(657, 69, false);
#line 32 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Edit Student", "Edit", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(726, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(735, 73, false);
#line 33 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Delete Student", "Delete", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(808, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(817, 74, false);
#line 34 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Add a Course", "AddCourse", new { id = Model.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(891, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
