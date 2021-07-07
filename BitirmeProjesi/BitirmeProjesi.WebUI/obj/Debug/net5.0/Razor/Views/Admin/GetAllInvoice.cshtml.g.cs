#pragma checksum "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8453617bbe764c3afde4ae18043e72dbe02a78a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllInvoice), @"mvc.1.0.view", @"/Views/Admin/GetAllInvoice.cshtml")]
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
#line 1 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\_ViewImports.cshtml"
using BitirmeProjesi.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\_ViewImports.cshtml"
using BitirmeProjesi.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\_ViewImports.cshtml"
using BitirmeProjesi.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8453617bbe764c3afde4ae18043e72dbe02a78a", @"/Views/Admin/GetAllInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07dba8df928506a7e28b1dd7fc8e9f1032391efb", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<string, Invoice>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
     foreach (var group in Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n\r\n                <h1 class=\"text-danger\"> ");
#nullable restore
#line 11 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                    Write(group.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <h3>Fatura Sayısı :  ");
#nullable restore
#line 12 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                Write(group.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 13 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                 foreach (var invoice in group)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3>Kullanıcı Bilgileri</h3>\r\n                    <ul>\r\n                        <li>Daire Sakini : ");
#nullable restore
#line 17 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                      Write(invoice.Circle.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                                                     Write(invoice.Circle.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li>Telefon No :");
#nullable restore
#line 18 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                   Write(invoice.Circle.User.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li>Mail Adresş :");
#nullable restore
#line 19 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                    Write(invoice.Circle.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <h3>Daire Bilgileri</h3>\r\n                    <ul>\r\n                        <li>\r\n                            Daire Blok : ");
#nullable restore
#line 24 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                    Write(invoice.Circle.Block);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            Daire Katı :");
#nullable restore
#line 27 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                   Write(invoice.Circle.Floor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            Daire No :");
#nullable restore
#line 30 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                 Write(invoice.Circle.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                    <h3>Fatura Bilgileri </h3>\r\n                    <ul>\r\n                        <li>Aidat : ");
#nullable restore
#line 35 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                               Write(invoice.Dues);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        <li>Elektirik : ");
#nullable restore
#line 36 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                   Write(invoice.ElectricityBill);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        <li>Doğalgaz : ");
#nullable restore
#line 37 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                                  Write(invoice.GasBill);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        <li>Su : ");
#nullable restore
#line 38 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
                            Write(invoice.WaterBill);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                    </ul>\r\n                    <hr />\r\n");
#nullable restore
#line 41 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllInvoice.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<string, Invoice>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
