#pragma checksum "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/Home/Number.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2875115624214d59f94390d03a1d642e94b3050"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Number), @"mvc.1.0.view", @"/Views/Home/Number.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Number.cshtml", typeof(AspNetCore.Views_Home_Number))]
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
#line 1 "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2875115624214d59f94390d03a1d642e94b3050", @"/Views/Home/Number.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Number : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NumberMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 82, true);
            WriteLiteral("<div class=\"row\">\n  <div class=\"col\">\n    <p class=\"text-center mt-4 mb-5\">\n      ");
            EndContext();
            BeginContext(104, 13, false);
#line 5 "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/Home/Number.cshtml"
 Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(117, 88, true);
            WriteLiteral("\n    </p>\n  </div>\n</div>\n<div class=\"row\">\n  <div class=\"col-md-6 offset-md-3\">\n    <p>");
            EndContext();
#line 11 "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/Home/Number.cshtml"
        foreach(int num in Model.NumNumber)
      {

#line default
#line hidden
            BeginContext(250, 9, true);
            WriteLiteral("      <p>");
            EndContext();
            BeginContext(260, 3, false);
#line 13 "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/Home/Number.cshtml"
    Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(263, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 14 "/Users/dave/codingDojo/C#_stack/ASP_MVC_1/ViewModelFun/Views/Home/Number.cshtml"
      }

#line default
#line hidden
            BeginContext(276, 24, true);
            WriteLiteral("    </p>\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NumberMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
