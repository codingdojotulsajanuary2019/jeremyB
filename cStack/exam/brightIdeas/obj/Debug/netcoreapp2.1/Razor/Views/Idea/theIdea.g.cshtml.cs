#pragma checksum "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bda4b439cfa2abb58ac0bd2d0d1ff591707e90d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_theIdea), @"mvc.1.0.view", @"/Views/Idea/theIdea.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/theIdea.cshtml", typeof(AspNetCore.Views_Idea_theIdea))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bda4b439cfa2abb58ac0bd2d0d1ff591707e90d", @"/Views/Idea/theIdea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4078d6f55194b4c66245963c91b2696ba847e7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_theIdea : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 863, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""section has-background-primary"">
        <div class=""navbar is-primary"">
            <div class=""level"">
                <div class=""level-left"">
                    <div class=""level-item"">
                        <h1 class=""title"">Take a closer look!</h1>
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
            <div class=""columns is-vcentered"">
                <div class=""column is-2"">
                    <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 875, "\"", 909, 2);
            WriteAttributeValue("", 882, "/user/", 882, 6, true);
#line 24 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
WriteAttributeValue("", 888, Model.creator.UserId, 888, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(910, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(912, 19, false);
#line 24 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
                                                        Write(Model.creator.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(931, 111, true);
            WriteLiteral("</a> says:</p>\n                </div>\n                <div class=\"column\">\n                    <p class=\"idea\">");
            EndContext();
            BeginContext(1043, 13, false);
#line 27 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
                               Write(Model.content);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 618, true);
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""section"">
                <div class=""columns is-centered"">
                    <div class=""column is-half is-centered"">
                        <p>People who liked this post:</p>
                        <table class=""table is-bordered is-fullwidth is-striped"">
                            <thead>
                                <tr>
                                    <th>Alias</th>
                                    <th>Name</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 42 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
                                 foreach(var like in @Model.likes)
                                {

#line default
#line hidden
            BeginContext(1775, 85, true);
            WriteLiteral("                                    <tr>\n                                        <td>");
            EndContext();
            BeginContext(1861, 18, false);
#line 45 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
                                       Write(like.theUser.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(1879, 50, true);
            WriteLiteral("</td>\n                                        <td>");
            EndContext();
            BeginContext(1930, 17, false);
#line 46 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
                                       Write(like.theUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 48, true);
            WriteLiteral("</td>\n                                    </tr>\n");
            EndContext();
#line 48 "/Users/JB/Documents/codingDojo/cStack/exam/brightIdeas/Views/Idea/theIdea.cshtml"
                                }

#line default
#line hidden
            BeginContext(2029, 169, true);
            WriteLiteral("                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n<div");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
