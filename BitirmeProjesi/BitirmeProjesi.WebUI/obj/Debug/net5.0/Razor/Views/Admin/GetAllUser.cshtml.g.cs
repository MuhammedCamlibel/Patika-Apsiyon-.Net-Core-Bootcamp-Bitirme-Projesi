#pragma checksum "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0788f6998d194f13571a232d4fc75c0402f129b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllUser), @"mvc.1.0.view", @"/Views/Admin/GetAllUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0788f6998d194f13571a232d4fc75c0402f129b2", @"/Views/Admin/GetAllUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07dba8df928506a7e28b1dd7fc8e9f1032391efb", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/DeleteUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"
         foreach (var user in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <div class=\"card-body\">\r\n                        <h3>");
#nullable restore
#line 11 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"
                       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"
                                       Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"card-text\"> Kullan??c?? ??zerinde b??t??n i??lemleri bu alan i??inde yapabilirsiniz </p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 473, "\"", 503, 2);
            WriteAttributeValue("", 480, "/Admin/GetUser/", 480, 15, true);
#nullable restore
#line 13 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"
WriteAttributeValue("", 495, user.Id, 495, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Get User</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 602, 2);
            WriteAttributeValue("", 576, "/Admin/UpdateUser/", 576, 18, true);
#nullable restore
#line 14 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"
WriteAttributeValue("", 594, user.Id, 594, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Update User</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0788f6998d194f13571a232d4fc75c0402f129b26383", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 776, "\"", 792, 1);
#nullable restore
#line 16 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"
WriteAttributeValue("", 784, user.Id, 784, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Delete User</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\Muhammed\source\repos\BitirmeProjesi\BitirmeProjesi.WebUI\Views\Admin\GetAllUser.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
