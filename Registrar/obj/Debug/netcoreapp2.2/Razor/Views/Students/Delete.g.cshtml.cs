#pragma checksum "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16bc624e7723edc7abf8103c5d57a197aa416ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Delete), @"mvc.1.0.view", @"/Views/Students/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Delete.cshtml", typeof(AspNetCore.Views_Students_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16bc624e7723edc7abf8103c5d57a197aa416ab2", @"/Views/Students/Delete.cshtml")]
    public class Views_Students_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 57, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this Student?</h2>\n\n");
            EndContext();
            BeginContext(118, 47, false);
#line 9 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(165, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(168, 43, false);
#line 9 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(211, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(240, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(286, 43, false);
#line 14 "/Users/Zaayer/Desktop/Registrar.Solution/Registrar/Views/Students/Delete.cshtml"
Write(Html.ActionLink("Back to Student", "Index"));

#line default
#line hidden
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
