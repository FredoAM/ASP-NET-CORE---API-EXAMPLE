#pragma checksum "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d92fd8a4e8a648993b34923c0f36f1cc6ec8099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\_ViewImports.cshtml"
using APIEJEMPLO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\_ViewImports.cshtml"
using APIEJEMPLO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d92fd8a4e8a648993b34923c0f36f1cc6ec8099", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f4713a3796df44b3d4a6401446e69d953533d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Products";

    var products = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 8 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
     foreach (var product in products) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <strong>Id:</strong> ");
#nullable restore
#line 10 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
                            Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <strong>Name:</strong> ");
#nullable restore
#line 12 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
                              Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <strong>Description:</strong> ");
#nullable restore
#line 14 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
                                     Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <strong>Price:</strong> ");
#nullable restore
#line 16 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <strong>Image:</strong> <img");
            BeginWriteAttribute("src", " src=\"", 469, "\"", 492, 1);
#nullable restore
#line 18 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
WriteAttributeValue("", 475, product.ImageUrl, 475, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <br />\r\n            <strong>Rating:</strong> ");
#nullable restore
#line 20 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
                                Write(product.Rating.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <strong>Rating count:</strong> ");
#nullable restore
#line 22 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
                                      Write(product.Rating.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 24 "C:\Users\fredo\source\repos\APIEJEMPLO\APIEJEMPLO\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
