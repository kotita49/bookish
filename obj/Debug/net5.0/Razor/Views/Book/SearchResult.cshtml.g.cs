#pragma checksum "C:\Training\Bookish\Views\Book\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6010fbcb338e057fc46edc593d45c72b3f964f82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_SearchResult), @"mvc.1.0.view", @"/Views/Book/SearchResult.cshtml")]
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
#line 1 "C:\Training\Bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\Bookish\Views\_ViewImports.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6010fbcb338e057fc46edc593d45c72b3f964f82", @"/Views/Book/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookish.Models.ListOfBooks>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Training\Bookish\Views\Book\SearchResult.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <h1 class=\"display-4\">Search result</h1>\r\n    <br>\r\n");
#nullable restore
#line 11 "C:\Training\Bookish\Views\Book\SearchResult.cshtml"
     foreach (var b in Model.BookList){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Title: ");
#nullable restore
#line 12 "C:\Training\Bookish\Views\Book\SearchResult.cshtml"
          Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n     <h3>Author: ");
#nullable restore
#line 13 "C:\Training\Bookish\Views\Book\SearchResult.cshtml"
            Write(b.BookAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Published on: ");
#nullable restore
#line 14 "C:\Training\Bookish\Views\Book\SearchResult.cshtml"
                 Write(b.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <br>\r\n");
#nullable restore
#line 16 "C:\Training\Bookish\Views\Book\SearchResult.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookish.Models.ListOfBooks> Html { get; private set; }
    }
}
#pragma warning restore 1591