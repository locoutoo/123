#pragma checksum "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff4df828f6987fa3a33034a229af0f19b394a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\_ViewImports.cshtml"
using EsteCarII;

#line default
#line hidden
#line 2 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\_ViewImports.cshtml"
using EsteCarII.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff4df828f6987fa3a33034a229af0f19b394a0c", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c6a071bfe6f38e14e3cfd12cc266eae087362a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Sobre Nós";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(50, 17, false);
#line 4 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(67, 48, true);
            WriteLiteral("</h2>\r\n\r\n<p>ESTe Carro</p>\r\n<br/>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(116, 44, false);
#line 10 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\Home\About.cshtml"
Write(await Component.InvokeAsync("AlugueresHoje"));

#line default
#line hidden
            EndContext();
            BeginContext(160, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
