#pragma checksum "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d880f3f2e07819acfa69c1b7e5fafb352f2d1141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index2), @"mvc.1.0.view", @"/Views/Dashboard/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index2.cshtml", typeof(AspNetCore.Views_Dashboard_Index2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d880f3f2e07819acfa69c1b7e5fafb352f2d1141", @"/Views/Dashboard/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb15c43ca34d0757bf544ad01cf9e6fac7aec62", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentACar.Models.CarModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 90, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(137, 38, false);
#line 9 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(175, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(231, 44, false);
#line 12 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.Carbrand));

#line default
#line hidden
            EndContext();
            BeginContext(275, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(331, 44, false);
#line 15 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.Carmodel));

#line default
#line hidden
            EndContext();
            BeginContext(375, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(431, 41, false);
#line 18 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(472, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(528, 43, false);
#line 21 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.Gearbox));

#line default
#line hidden
            EndContext();
            BeginContext(571, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(689, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(738, 37, false);
#line 30 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(775, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(831, 43, false);
#line 33 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Carbrand));

#line default
#line hidden
            EndContext();
            BeginContext(874, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(930, 43, false);
#line 36 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Carmodel));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1029, 40, false);
#line 39 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1125, 42, false);
#line 42 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gearbox));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 50, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\PC\Desktop\Projects\RentACar\RentACar\RentACar\Views\Dashboard\Index2.cshtml"
}

#line default
#line hidden
            BeginContext(1220, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentACar.Models.CarModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
