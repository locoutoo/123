#pragma checksum "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\Shared\Components\AlugueresHoje\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd29948016ffd24fa9604fbbda91e84676a98750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AlugueresHoje_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AlugueresHoje/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AlugueresHoje/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AlugueresHoje_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd29948016ffd24fa9604fbbda91e84676a98750", @"/Views/Shared/Components/AlugueresHoje/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c6a071bfe6f38e14e3cfd12cc266eae087362a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AlugueresHoje_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EsteCarII.Models.Aluguer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 100, true);
            WriteLiteral("\r\n<table frame=\"box\">\r\n    <tr>\r\n        <th>Alugueres</th>\r\n    </tr>\r\n    <tr>\r\n        <td>Hoje: ");
            EndContext();
            BeginContext(147, 13, false);
#line 8 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 8\EsteCarII\EsteCarII\Views\Shared\Components\AlugueresHoje\Default.cshtml"
             Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(160, 40, true);
            WriteLiteral(" alugueres</td>\r\n    </tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EsteCarII.Models.Aluguer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
