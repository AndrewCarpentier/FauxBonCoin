#pragma checksum "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a47d12c81e5d1b4b66d466797ddd1f3be16148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Annonces_Depot), @"mvc.1.0.view", @"/Views/Annonces/Depot.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Annonces/Depot.cshtml", typeof(AspNetCore.Views_Annonces_Depot))]
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
#line 1 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\_ViewImports.cshtml"
using FauxBonCoin;

#line default
#line hidden
#line 1 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
using FauxBonCoin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a47d12c81e5d1b4b66d466797ddd1f3be16148", @"/Views/Annonces/Depot.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6306237d59ca3377714ed795287d07f7afff51df", @"/Views/_ViewImports.cshtml")]
    public class Views_Annonces_Depot : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Annonces", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeposerAnnoncePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 50, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n");
            EndContext();
#line 5 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
         if ((ViewBag.errors != null))
        {
            if ((ViewBag.errors as List<string>).Count > 0)
            {

#line default
#line hidden
            BeginContext(204, 99, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-lg-12 alert alert-danger\">\r\n");
            EndContext();
#line 11 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                         foreach (string e in (ViewBag.errors as List<string>))
                        {

#line default
#line hidden
            BeginContext(411, 140, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-lg-12\">\r\n                                    ");
            EndContext();
            BeginContext(552, 1, false);
#line 15 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                               Write(e);

#line default
#line hidden
            EndContext();
            BeginContext(553, 78, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 18 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                        }

#line default
#line hidden
            BeginContext(658, 52, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(736, 91, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 depotAnnonce\">\r\n        ");
            EndContext();
            BeginContext(827, 1452, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2782be79c4f4be3b39851abefc59dc7", async() => {
                BeginContext(935, 390, true);
                WriteLiteral(@"
            <div class=""row"">
                <h2 class=""col-lg-12"">Deposer une annonce</h2>
            </div>
            <div class=""row"">
                <input type=""text"" name=""titre"" class=""form-control"" placeholder=""Titre de l'annonce"" />
            </div>
            <div class=""row"">
                <select name=""categorie"" class=""form-control"" >
                    ");
                EndContext();
                BeginContext(1325, 17, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87349c197f1e4ea5b7765b5f4dd4e99f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1342, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                     foreach(Category c in (ViewBag.ListeCategories as List<Category>)) {

#line default
#line hidden
                BeginContext(1435, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1459, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "569710866e8140e7911729f642727eaa", async() => {
                    BeginContext(1482, 7, false);
#line 39 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                                         Write(c.Titre);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 39 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                           WriteLiteral(c.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1498, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\Users\Administrateur\Downloads\FauxBonCoin (5)\FauxBonCoin\FauxBonCoin\Views\Annonces\Depot.cshtml"
                    }

#line default
#line hidden
                BeginContext(1523, 749, true);
                WriteLiteral(@"                </select>
            </div>
            <div class=""row"">
                <textarea name=""description"" class=""form-control"" placeholder=""La description de l'annonce"">

                </textarea>
            </div>
            <div class=""row"">
                <input placeholder=""Le prix de l'annonce"" name=""prix"" type=""text"" class=""form-control"" />
            </div>
            <div class=""row"">
                <input type=""file"" name=""images"" multiple placeholder=""Les images de l'annonce"" class=""form-control"" />
            </div>
            <div class=""row"">
                <button type=""submit"" class=""btn btn-default"" >
                    Ajouter
                </button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2279, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
