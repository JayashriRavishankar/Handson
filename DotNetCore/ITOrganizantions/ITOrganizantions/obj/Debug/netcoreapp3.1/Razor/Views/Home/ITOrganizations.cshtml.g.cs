#pragma checksum "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c458b2387e00ef10cf7ec8a14695f0223afb271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\_ViewImports.cshtml"
using ITOrganizantions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\_ViewImports.cshtml"
using ITOrganizantions.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c458b2387e00ef10cf7ec8a14695f0223afb271", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2553bc04c9551f304841482e52d1e107a966393", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
   ViewData["Title"] = "ITOrganizations";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<string> organizations = new List<string> 
    {"Microsoft www. microsoft.com", "Amazon", " TCS", "Google", "CTS www.cognizant.com" }; 
  
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ITOrganizations in Hyderabad</h1>\r\n\r\n");
#nullable restore
#line 15 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
 foreach (var org in organizations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <span>\r\n");
#nullable restore
#line 19 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
         if (org == "Amazon")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <b>");
#nullable restore
#line 21 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
          Write(org);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 22 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
       Write(org);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
                

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span>\r\n</div>\r\n");
#nullable restore
#line 30 "C:\jayasri\Handson\Handson\DotNetCore\ITOrganizantions\ITOrganizantions\Views\Home\ITOrganizations.cshtml"
}

#line default
#line hidden
#nullable disable
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