#pragma checksum "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd4f8f32ce639f40771a22c666552ea1106f716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venue_Search), @"mvc.1.0.view", @"/Views/Venue/Search.cshtml")]
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
#line 1 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\_ViewImports.cshtml"
using Venue_Finder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\_ViewImports.cshtml"
using Venue_Finder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd4f8f32ce639f40771a22c666552ea1106f716", @"/Views/Venue/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b63b81cad08c6e9f1f6c9435a6d737ae3a3fcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Venue_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Search</h1>\r\n");
#nullable restore
#line 10 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
 foreach(var venue in Model) 
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 13 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 14 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 15 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 16 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 17 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 18 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 19 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.state);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    ");
#nullable restore
#line 20 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
Write(venue.zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n</div>\r\n");
#nullable restore
#line 22 "C:\Users\alexa\source\repos\Venue Finder\Venue Finder\Views\Venue\Search.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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