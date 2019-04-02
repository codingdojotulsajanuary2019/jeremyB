#pragma checksum "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4324f747a7c2631f2a39faf4a929236a30cdc31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wed_Dashboard), @"mvc.1.0.view", @"/Views/Wed/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wed/Dashboard.cshtml", typeof(AspNetCore.Views_Wed_Dashboard))]
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
#line 1 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/_ViewImports.cshtml"
using weddingPlanner;

#line default
#line hidden
#line 1 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
using weddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4324f747a7c2631f2a39faf4a929236a30cdc31b", @"/Views/Wed/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d2f7e7fad137d735531a94f00fd8cb8297fea8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Wed_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1076, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""section has-background-primary"">
        <div class=""navbar is-primary"">
            <div class=""level"">
                <div class=""level-left"">
                    <div class=""level-item"">
                        <h1 class=""title"">Welcome to wedding planner!</h1>
                    </div>
                </div>
                <div class=""level-right offset-right"">
                    <div class=""level-item has-text-right"">
                        <a href=""logout"">Log Out</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""section has-background-dark"">
        <div class=""box has-text-centered"">
            <table class=""table is-bordered is-fullwidth is-striped is-hoverable"">
                <thead>
                    <tr>
                        <th>Wedding</th>
                        <th>Date</th>
                        <th>Guests</th>
                        <th>Action</th>
                    </t");
            WriteLiteral("r>\n                </thead>\n                <tbody>\n");
            EndContext();
#line 33 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                     foreach(var thisWed in @Model.weddingList)
                    {

#line default
#line hidden
            BeginContext(1205, 63, true);
            WriteLiteral("                        <tr>\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1268, "\"", 1302, 2);
            WriteAttributeValue("", 1275, "/wedding/", 1275, 9, true);
#line 36 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
WriteAttributeValue("", 1284, thisWed.weddingId, 1284, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1303, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1305, 14, false);
#line 36 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                                                                 Write(thisWed.wedOne);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(1323, 14, false);
#line 36 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                                                                                   Write(thisWed.wedTwo);

#line default
#line hidden
            EndContext();
            BeginContext(1337, 42, true);
            WriteLiteral("</a></td>\n                            <td>");
            EndContext();
            BeginContext(1380, 35, false);
#line 37 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                           Write(thisWed.date.ToString("dd MMM yyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1454, 22, false);
#line 38 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                           Write(thisWed.guests.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1476, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 39 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                             if(thisWed.creator.UserId == Model.creator.UserId) {

#line default
#line hidden
            BeginContext(1564, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1602, "\"", 1635, 2);
            WriteAttributeValue("", 1609, "/delete/", 1609, 8, true);
#line 40 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
WriteAttributeValue("", 1617, thisWed.weddingId, 1617, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1636, 17, true);
            WriteLiteral(">Delete</a></td>\n");
            EndContext();
#line 41 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                            }
                            else if(thisWed.guests.Any(g => g.userId == Model.creator.UserId)) {

#line default
#line hidden
            BeginContext(1780, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1818, "\"", 1853, 2);
            WriteAttributeValue("", 1825, "/unattend/", 1825, 10, true);
#line 43 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
WriteAttributeValue("", 1835, thisWed.weddingId, 1835, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1854, 18, true);
            WriteLiteral(">Un-RSVP</a></td>\n");
            EndContext();
#line 44 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                            }
                            else {

#line default
#line hidden
            BeginContext(1937, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1975, "\"", 2008, 2);
            WriteAttributeValue("", 1982, "/attend/", 1982, 8, true);
#line 46 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
WriteAttributeValue("", 1990, thisWed.weddingId, 1990, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2009, 15, true);
            WriteLiteral(">RSVP</a></td>\n");
            EndContext();
#line 47 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                            }

#line default
#line hidden
            BeginContext(2054, 30, true);
            WriteLiteral("                        </tr>\n");
            EndContext();
#line 49 "/Users/JB/Documents/codingDojo/cStack/entity/weddingPlanner/Views/Wed/Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(2106, 159, true);
            WriteLiteral("                </tbody>\n            </table>\n            <a href=\"new\" class=\"button is-primary offset-right\">New Wedding</a>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
