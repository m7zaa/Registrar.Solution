#pragma checksum "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5abf5b628711c77d63346bdd9028e83635c1aef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 5 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
using Registrar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abf5b628711c77d63346bdd9028e83635c1aef6", @"/Views/Students/Index.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Registrar.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(92, 20, true);
            WriteLiteral("\n<h1>Students</h1>\n\n");
            EndContext();
#line 10 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(138, 44, true);
            WriteLiteral("  <h3>No students have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(185, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
 foreach (Student student in Model)
{

#line default
#line hidden
            BeginContext(224, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(231, 84, false);
#line 17 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
 Write(Html.ActionLink($"{student.StudentName}", "Details", new { id = student.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(315, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
}

#line default
#line hidden
            BeginContext(323, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(328, 44, false);
#line 20 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
Write(Html.ActionLink("Add new student", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(372, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(382, 40, false);
#line 22 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(422, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Registrar.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
