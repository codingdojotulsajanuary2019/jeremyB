#pragma checksum "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f2e1f95e4f22f67da071602b9177377e0f55ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/_ViewImports.cshtml"
using cruDelicious;

#line default
#line hidden
#line 1 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml"
using cruDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f2e1f95e4f22f67da071602b9177377e0f55ba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d76511d04d958eceed775cd3b7a2687e966c3255", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<alldishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 211, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"title\">Welcome to CRUDelicious</h1>\r\n    <div class=\"level\">\r\n        <p>Check out some recent dishes!</p>\r\n        <a href=\"/new\">Add a dish</a>\r\n    </div>\r\n    <hr>\r\n");
            EndContext();
#line 11 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml"
     foreach(var dish in @Model.allDishes)
    {   

#line default
#line hidden
            BeginContext(311, 13, true);
            WriteLiteral("        <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 324, "\"", 344, 2);
            WriteAttributeValue("", 331, "/", 331, 1, true);
#line 13 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 332, dish.DishId, 332, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(345, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(347, 9, false);
#line 13 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml"
                              Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(356, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(365, 9, false);
#line 13 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml"
                                                Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(374, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "/Users/JB/Documents/codingDojo/cStack/entity/cruDelicious/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(387, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<alldishes> Html { get; private set; }
    }
}
#pragma warning restore 1591