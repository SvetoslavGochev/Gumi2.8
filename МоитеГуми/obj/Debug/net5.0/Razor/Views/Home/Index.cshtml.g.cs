#pragma checksum "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24f28eae956d082c4289050b74ee996bcbe67f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Services.Obqwi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Services.Dealers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Models.Обява;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Models.Dealers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\_ViewImports.cshtml"
using МоитеГуми.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24f28eae956d082c4289050b74ee996bcbe67f8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b0277a9f74b7fcb7c090b28df3e407a4528e0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObqwaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Обява", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
 if (!Model.obqwi.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron\">\n    <h1 class=\"display-4\">Добре дошли в МоитеГуми</h1>\n    <p class=\"lead\">Няма обяви в момента</p>\n    <hr class=\"my-4\">\n    <p class=\"lead\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24f28eae956d082c4289050b74ee996bcbe67f86723", async() => {
                WriteLiteral("Добави Обява");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n</div> ");
#nullable restore
#line 15 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
       } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Последни три обяви</h3>\n<div class=\"mb-5\"></div>\n<div id=\"carouselExampleControls\" class=\"carousel slide col-md-6\" data-ride=\"carousel\">\n    <div class=\"carousel-inner \">\n");
#nullable restore
#line 41 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
         for (int i = 0; i < Model.obqwi.Count; i++)
        {
            var obqwa = Model.obqwi[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 1716, "\"", 1773, 2);
            WriteAttributeValue("", 1724, "carousel-item", 1724, 13, true);
#nullable restore
#line 45 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1737, i == 0 ? "active" : string.Empty, 1738, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <img");
            BeginWriteAttribute("src", " src=\"", 1784, "\"", 1805, 1);
#nullable restore
#line 46 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
WriteAttributeValue("", 1790, obqwa.ImageUrl, 1790, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\"");
            BeginWriteAttribute("alt", " alt=\"", 1828, "\"", 1874, 3);
#nullable restore
#line 46 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
WriteAttributeValue("", 1834, obqwa.Marka, 1834, 12, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1846, obqwa.Size, 1847, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1858, obqwa.Category, 1859, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"carousel-caption d-none d-md-block\">\n        <h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24f28eae956d082c4289050b74ee996bcbe67f810633", async() => {
                WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
                                                                                                     Write(obqwa.Marka);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
                                                                                                                  Write(obqwa.Size);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
                                                                                                                              Write(obqwa.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
                                                                                  WriteLiteral(obqwa.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</h5>\n    </div>\n</div>");
#nullable restore
#line 50 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""mb-5""></div>



<div class=""jumbotron"">
    <div class=""row"">
        <div class=""col-md-6 text-center"">
            ");
#nullable restore
#line 69 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
       Write(Model.CountAnnouncement);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Обяви\n        </div>\n        <div class=\"col-md-6 text-center\">\n            ");
#nullable restore
#line 72 "C:\Users\Svetoslav\Desktop\Gumi2.8\МоитеГуми\Views\Home\Index.cshtml"
       Write(Model.CountUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Брой потребители\n        </div>\n\n    </div>\n</div>\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObqwaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
