#pragma checksum "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c096e27ab2f66f8a857dc97d7445554e021f992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alugueres_Details), @"mvc.1.0.view", @"/Views/Alugueres/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alugueres/Details.cshtml", typeof(AspNetCore.Views_Alugueres_Details))]
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
#line 1 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\_ViewImports.cshtml"
using EsteCarII;

#line default
#line hidden
#line 2 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\_ViewImports.cshtml"
using EsteCarII.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c096e27ab2f66f8a857dc97d7445554e021f992", @"/Views/Alugueres/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c6a071bfe6f38e14e3cfd12cc266eae087362a", @"/Views/_ViewImports.cshtml")]
    public class Views_Alugueres_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EsteCarII.Models.Aluguer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Aluguer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(247, 50, false);
#line 15 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LocalDeEntrega));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(341, 46, false);
#line 18 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocalDeEntrega));

#line default
#line hidden
            EndContext();
            BeginContext(387, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(431, 50, false);
#line 21 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LocalDeRecolha));

#line default
#line hidden
            EndContext();
            BeginContext(481, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(525, 46, false);
#line 24 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocalDeRecolha));

#line default
#line hidden
            EndContext();
            BeginContext(571, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(615, 46, false);
#line 27 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(661, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(705, 42, false);
#line 30 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(747, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(791, 43, false);
#line 33 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(834, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(878, 39, false);
#line 36 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(917, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(961, 41, false);
#line 39 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Carro));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1046, 44, false);
#line 42 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayFor(model => model.Carro.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1134, 43, false);
#line 45 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1221, 44, false);
#line 48 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1312, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec19f830597540648ac01f5a2c51f566", async() => {
                BeginContext(1365, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Jose-MSI\Dropbox\PV 2018-2019 Pessoal\Labs working\Lab 9\EsteCarII\EsteCarII\Views\Alugueres\Details.cshtml"
                           WriteLiteral(Model.AluguerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1373, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1381, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a5807afdbd64fc7908d807d22617952", async() => {
                BeginContext(1403, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EsteCarII.Models.Aluguer> Html { get; private set; }
    }
}
#pragma warning restore 1591
