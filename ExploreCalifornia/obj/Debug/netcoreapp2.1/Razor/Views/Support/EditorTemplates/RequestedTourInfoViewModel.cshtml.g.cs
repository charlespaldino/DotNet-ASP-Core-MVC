#pragma checksum "C:\Users\BLUEMAGIC SE GAMING\source\repos\ExploreCalifornia\Views\Support\EditorTemplates\RequestedTourInfoViewModel.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7dc04de88dba2f615acdd07a5c0717a4218274cf4ee3a2e473d4420a2044f852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Support_EditorTemplates_RequestedTourInfoViewModel), @"mvc.1.0.view", @"/Views/Support/EditorTemplates/RequestedTourInfoViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Support/EditorTemplates/RequestedTourInfoViewModel.cshtml", typeof(AspNetCore.Views_Support_EditorTemplates_RequestedTourInfoViewModel))]
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
#line 1 "C:\Users\BLUEMAGIC SE GAMING\source\repos\ExploreCalifornia\Views\Support\EditorTemplates\RequestedTourInfoViewModel.cshtml"
using ExploreCalifornia.Models.Support;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7dc04de88dba2f615acdd07a5c0717a4218274cf4ee3a2e473d4420a2044f852", @"/Views/Support/EditorTemplates/RequestedTourInfoViewModel.cshtml")]
    public class Views_Support_EditorTemplates_RequestedTourInfoViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestedTourInfoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 39, true);
            WriteLiteral("\r\n<div class=\"col3\">\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(116, 35, false);
#line 6 "C:\Users\BLUEMAGIC SE GAMING\source\repos\ExploreCalifornia\Views\Support\EditorTemplates\RequestedTourInfoViewModel.cshtml"
   Write(Html.CheckBoxFor(x => x.IsSelected));

#line default
#line hidden
            EndContext();
            BeginContext(151, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(153, 10, false);
#line 6 "C:\Users\BLUEMAGIC SE GAMING\source\repos\ExploreCalifornia\Views\Support\EditorTemplates\RequestedTourInfoViewModel.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(163, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(174, 25, false);
#line 7 "C:\Users\BLUEMAGIC SE GAMING\source\repos\ExploreCalifornia\Views\Support\EditorTemplates\RequestedTourInfoViewModel.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(199, 18, true);
            WriteLiteral("\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RequestedTourInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
