#pragma checksum "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6def2b1d507cb2f63c9165ec74335641b2e2aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(firstpage.Pages.Pages_Students), @"mvc.1.0.razor-page", @"/Pages/Students.cshtml")]
namespace firstpage.Pages
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
#line 1 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/_ViewImports.cshtml"
using firstpage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
using Microsoft.Extensions.WebEncoders.Testing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
using firstpage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6def2b1d507cb2f63c9165ec74335641b2e2aa", @"/Pages/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2557358270d2ca5d988dcaa86a0086db077b14c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class = \"table\">\r\n <thead>\r\n <tr>\r\n  <th> Student Id</th>\r\n  <th> Student name</th>\r\n  <th> classId </th>\r\n </tr>\r\n </thead>  \r\n  <tbody>\r\n");
#nullable restore
#line 18 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
  foreach ( var student in  Model.AllStudents)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <tr>\r\n    <td>");
#nullable restore
#line 21 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
   Write(student.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
   Write(student.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
   Write(student.classId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 25 "/home/elia/becode-repositories/dotnet/dotnet-exercises/firstpage/Pages/Students.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<firstpage.Pages.StudentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<firstpage.Pages.StudentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<firstpage.Pages.StudentModel>)PageContext?.ViewData;
        public firstpage.Pages.StudentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
