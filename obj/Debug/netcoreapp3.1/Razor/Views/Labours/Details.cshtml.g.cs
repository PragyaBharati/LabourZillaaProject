#pragma checksum "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e30ee922cfd8d15829968b74ef1d1a9ba75043c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Labours_Details), @"mvc.1.0.view", @"/Views/Labours/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e30ee922cfd8d15829968b74ef1d1a9ba75043c", @"/Views/Labours/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0893c9817daa39c76df5b27b061d750270faade8", @"/Views/_ViewImports.cshtml")]
    public class Views_Labours_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LabourZillaZoneee.Models.Labour>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Labour</h4>\r\n    <hr />\r\n    <dl class=\"row\" style=\"background-color:lightskyblue\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pswd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pswd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cnfrmpswd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cnfrmpswd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Profession));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.Profession));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CityAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.CityAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StateL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.StateL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DailyWages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.DailyWages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TimeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.TimeDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lcontact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lcontact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ppic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ppic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoleL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\user\Desktop\Coforge\ProjectLabourZilla\LabourZillaZoneee\Views\Labours\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoleL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e30ee922cfd8d15829968b74ef1d1a9ba75043c12659", async() => {
                WriteLiteral("<button>Back to List</button>");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LabourZillaZoneee.Models.Labour> Html { get; private set; }
    }
}
#pragma warning restore 1591
