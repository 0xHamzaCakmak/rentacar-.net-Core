#pragma checksum "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac60af503b9095450bbd91943b869bfda86ed087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserDetails), @"mvc.1.0.view", @"/Views/User/UserDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserDetails.cshtml", typeof(AspNetCore.Views_User_UserDetails))]
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
#line 1 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\_ViewImports.cshtml"
using RentACar;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\_ViewImports.cshtml"
using RentACar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac60af503b9095450bbd91943b869bfda86ed087", @"/Views/User/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb15c43ca34d0757bf544ad01cf9e6fac7aec62", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentACar.Models.UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
  
    ViewData["Title"] = "UserDetails";

#line default
#line hidden
            BeginContext(96, 35, true);
            WriteLiteral("\r\n<h2>UserDetails</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d84a9686bf4dfcac838590fd44ac74", async() => {
                BeginContext(154, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 38, false);
#line 16 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 40, false);
#line 19 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(395, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(451, 43, false);
#line 22 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(550, 44, false);
#line 25 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(650, 44, false);
#line 28 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(694, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(750, 41, false);
#line 31 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(791, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(847, 48, false);
#line 34 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.isSuperAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(895, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1013, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1062, 37, false);
#line 43 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1155, 39, false);
#line 46 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1250, 42, false);
#line 49 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1348, 43, false);
#line 52 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1447, 43, false);
#line 55 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1546, 40, false);
#line 58 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1642, 47, false);
#line 61 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.isSuperAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1745, 57, false);
#line 64 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.ActionLink("Güncelle", "Update", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1823, 155, false);
#line 65 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
           Write(Html.ActionLink("Sil", "Delete", new { id=item.Id },new { onclick = $"return confirm('{item.Name} adlı Kullanıcıyı silmek istediğinize emin misiniz?');" }));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\User\UserDetails.cshtml"
}

#line default
#line hidden
            BeginContext(2017, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentACar.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
