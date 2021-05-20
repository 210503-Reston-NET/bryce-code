#pragma checksum "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e3b20d36527afe6bc7533d0ae42a1ebf5fd993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_Index), @"mvc.1.0.view", @"/Views/Review/Index.cshtml")]
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
#line 1 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/_ViewImports.cshtml"
using RRWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/_ViewImports.cshtml"
using RRWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e3b20d36527afe6bc7533d0ae42a1ebf5fd993", @"/Views/Review/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3461e3086b9b87782c9db207abcb8ae981a531ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Review_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RRWebUI.Models.ReviewVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
Write(ViewBag.Restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Reviews</h1>\n<h4>Eat here: ");
#nullable restore
#line 8 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
         Write(ViewBag.Restaurant.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 8 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
                                   Write(ViewBag.Restaurant.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n<h6>Overall Rating: ");
#nullable restore
#line 9 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
               Write(ViewData["OverallRating"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\n<p>\n    ");
#nullable restore
#line 12 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
Write(Html.ActionLink("Add a review", "Create", new {id = ViewBag.Restaurant.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 18 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 26 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 29 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 32 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 35 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<p>\n    ");
#nullable restore
#line 39 "/Users/brycesmacbookair/Desktop/RestaurantReviews/RRWebUI/Views/Review/Index.cshtml"
Write(Html.ActionLink("Back to list of restaurants", "Index", "Restaurant"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RRWebUI.Models.ReviewVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591