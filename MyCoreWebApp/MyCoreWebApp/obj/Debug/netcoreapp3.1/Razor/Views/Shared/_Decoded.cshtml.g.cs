#pragma checksum "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\Shared\_Decoded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b2f3f727a780f19f9fd5d1bfb638d972c3e852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Decoded), @"mvc.1.0.view", @"/Views/Shared/_Decoded.cshtml")]
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
#nullable restore
#line 1 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\_ViewImports.cshtml"
using MyCoreWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\_ViewImports.cshtml"
using MyCoreWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b2f3f727a780f19f9fd5d1bfb638d972c3e852", @"/Views/Shared/_Decoded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c0bc697ce727db2dc8dc772917f84282eadb44", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Decoded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\Shared\_Decoded.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h2>");
#nullable restore
#line 5 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\Shared\_Decoded.cshtml"
   Write(ViewData["TextType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("text of ");
#nullable restore
#line 5 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\Shared\_Decoded.cshtml"
                                Write(ViewData["CipherName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>");
#nullable restore
#line 6 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\Shared\_Decoded.cshtml"
  Write(ViewData["text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 9 "C:\project\Web_application\MyCoreWebApp\MyCoreWebApp\Views\Shared\_Decoded.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
