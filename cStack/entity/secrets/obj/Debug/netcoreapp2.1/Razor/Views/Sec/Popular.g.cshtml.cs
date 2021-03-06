#pragma checksum "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab68e150ed143434ca816248c0ca33e933423ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sec_Popular), @"mvc.1.0.view", @"/Views/Sec/Popular.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sec/Popular.cshtml", typeof(AspNetCore.Views_Sec_Popular))]
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
#line 1 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/_ViewImports.cshtml"
using secrets;

#line default
#line hidden
#line 2 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/_ViewImports.cshtml"
using secrets.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab68e150ed143434ca816248c0ca33e933423ecd", @"/Views/Sec/Popular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca9f1a297acc775349a18aecff701db3c8cb656", @"/Views/_ViewImports.cshtml")]
    public class Views_Sec_Popular : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SecVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 783, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""section has-background-primary"">
        <div class=""navbar is-primary"">
            <div class=""level"">
                <div class=""level-left"">
                    <div class=""level-item"">
                        <h1 class=""title"">Welcome to Secrets!</h1>
                    </div>
                </div>
                <div class=""level-right"">
                    <div class=""level-item offset-right"">
                        <a href=""/logout"">Logout</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
     <div class=""section has-background-dark"">
            <div class=""box"">
                <div class=""container"">
                    <h1 class=""subtitle"">Most popular secrets...</h1>
");
            EndContext();
#line 23 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                     foreach(var s in @Model.allSec)
                    {

#line default
#line hidden
            BeginContext(871, 141, true);
            WriteLiteral("                        <br>\n                        <div class=\"container\">\n                            <p>\n                                ");
            EndContext();
            BeginContext(1013, 9, false);
#line 28 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                           Write(s.content);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1025, 33, false);
#line 28 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                                       Write(s.created_at.ToString("HH:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 2, true);
            WriteLiteral(") ");
            EndContext();
            BeginContext(1061, 15, false);
#line 28 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                                                                           Write(s.likes.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1076, 8, true);
            WriteLiteral(" likes \n");
            EndContext();
#line 29 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                                 if(s.creator.UserId == Model.thisUser.UserId){

#line default
#line hidden
            BeginContext(1164, 61, true);
            WriteLiteral("                                    <p>This is your secret <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1251, 2);
            WriteAttributeValue("", 1232, "/delete/", 1232, 8, true);
#line 30 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
WriteAttributeValue("", 1240, s.secretId, 1240, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1252, 16, true);
            WriteLiteral(">Delete</a></p>\n");
            EndContext();
#line 31 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                                }
                                else if(s.likes.Any(l => l.userId == Model.thisUser.UserId)){

#line default
#line hidden
            BeginContext(1396, 72, true);
            WriteLiteral("                                    <p>You have already liked this!</p>\n");
            EndContext();
#line 34 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                                }
                                else{

#line default
#line hidden
            BeginContext(1540, 41, true);
            WriteLiteral("                                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1581, "\"", 1605, 2);
            WriteAttributeValue("", 1588, "/like/", 1588, 6, true);
#line 36 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
WriteAttributeValue("", 1594, s.secretId, 1594, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1606, 14, true);
            WriteLiteral(">Like</a></p>\n");
            EndContext();
#line 37 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                                }

#line default
#line hidden
            BeginContext(1654, 64, true);
            WriteLiteral("                            </p>\n                        </div>\n");
            EndContext();
#line 40 "/Users/JB/Documents/codingDojo/cStack/entity/secrets/Views/Sec/Popular.cshtml"
                    }

#line default
#line hidden
            BeginContext(1740, 74, true);
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SecVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
