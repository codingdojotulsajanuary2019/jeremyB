#pragma checksum "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b67cead102beffa42da389cc44304b148f3a19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_theUser), @"mvc.1.0.view", @"/Views/Idea/theUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/theUser.cshtml", typeof(AspNetCore.Views_Idea_theUser))]
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
#line 1 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/_ViewImports.cshtml"
using brightIdeas;

#line default
#line hidden
#line 2 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/_ViewImports.cshtml"
using brightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b67cead102beffa42da389cc44304b148f3a19", @"/Views/Idea/theUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4078d6f55194b4c66245963c91b2696ba847e7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_theUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 807, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""section has-background-primary"">
        <div class=""navbar is-primary"">
            <div class=""level"">
                <div class=""level-left"">
                    <div class=""level-item"">
                        <h1 class=""title"">Chek this guy out!</h1>
                    </div>
                </div>
                <div class=""level-right offset-right spacer"">
                    <div class=""level-item "">
                        <a href=""/ideas"" class=""spacer"">Bright Ideas</a>
                        <a href=""/logout"">Logout</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""section has-background-dark"">
        <div class=""box"">
            <div class=""section"">
                <p>Name: ");
            EndContext();
            BeginContext(822, 19, false);
#line 23 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theUser.cshtml"
                    Write(Model.thisUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(841, 31, true);
            WriteLiteral("</p>\n                <p>Alias: ");
            EndContext();
            BeginContext(873, 20, false);
#line 24 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theUser.cshtml"
                     Write(Model.thisUser.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(893, 31, true);
            WriteLiteral("</p>\n                <p>Email: ");
            EndContext();
            BeginContext(925, 20, false);
#line 25 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theUser.cshtml"
                     Write(Model.thisUser.Email);

#line default
#line hidden
            EndContext();
            BeginContext(945, 68, true);
            WriteLiteral("</p>\n                <hr>\n                <p>Total Number of Posts: ");
            EndContext();
            BeginContext(1014, 28, false);
#line 27 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theUser.cshtml"
                                     Write(Model.thisUser.created.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 47, true);
            WriteLiteral("</p>\n                <p>Total Number of Likes: ");
            EndContext();
            BeginContext(1090, 21, false);
#line 28 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theUser.cshtml"
                                     Write(Model.userLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 56, true);
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
