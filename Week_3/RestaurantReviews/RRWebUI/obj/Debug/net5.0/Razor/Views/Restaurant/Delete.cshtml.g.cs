#pragma checksum "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e90f60eb1f10c4ff37d5380d5de2526f1c10ddf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Delete), @"mvc.1.0.view", @"/Views/Restaurant/Delete.cshtml")]
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
#line 1 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/_ViewImports.cshtml"
using RRWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/_ViewImports.cshtml"
using RRWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90f60eb1f10c4ff37d5380d5de2526f1c10ddf7", @"/Views/Restaurant/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3461e3086b9b87782c9db207abcb8ae981a531ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RRWebUI.Models.RestaurantVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this restaurant?</h3>\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "/Users/brycesmacbookair/Revature/bryce-code/Week_3/RestaurantReviews/RRWebUI/Views/Restaurant/Delete.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e90f60eb1f10c4ff37d5380d5de2526f1c10ddf77042", async() => {
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e90f60eb1f10c4ff37d5380d5de2526f1c10ddf77383", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RRWebUI.Models.RestaurantVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
