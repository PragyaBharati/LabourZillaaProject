#pragma checksum "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa61de10f33af6cdba674cd1ebf095a25a195a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Index), @"mvc.1.0.view", @"/Views/Admins/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\_ViewImports.cshtml"
using LabourZillaZoneee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\_ViewImports.cshtml"
using LabourZillaZoneee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa61de10f33af6cdba674cd1ebf095a25a195a0b", @"/Views/Admins/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0893c9817daa39c76df5b27b061d750270faade8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LabourZillaZoneee.Models.Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center\">Admin</h1>\r\n\r\n\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr style=\"background-color: teal\">\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoginId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AdminName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LoginId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdminName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoleA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Admins\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LabourZillaZoneee.Models.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591