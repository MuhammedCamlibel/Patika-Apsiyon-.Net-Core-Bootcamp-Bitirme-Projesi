#pragma checksum "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3ff65c634243b79dca2449f536947cb9ea475d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetUser), @"mvc.1.0.view", @"/Views/Admin/GetUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3ff65c634243b79dca2449f536947cb9ea475d", @"/Views/Admin/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07dba8df928506a7e28b1dd7fc8e9f1032391efb", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n\r\n                <h1>Kullanıcı Bilgileri </h1>\r\n                <ul>\r\n                    <li>Adı Soyadı : ");
#nullable restore
#line 9 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                                Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                                                 Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Kullanıcı Adı : ");
#nullable restore
#line 10 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                                   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Telefon : ");
#nullable restore
#line 11 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Email : ");
#nullable restore
#line 12 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>Araba Plakası : ");
#nullable restore
#line 13 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                                   Write(Model.CarPlate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li>TC No : ");
#nullable restore
#line 14 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetUser.cshtml"
                           Write(Model.TCNO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n    </div>  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591