#pragma checksum "C:\Users\15821\Documents\GitHub\Training-Assignments\MovieShop\MovieShop.MVC\Views\Account\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ed170e40032ff7810ec04de0564577f4627869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewProfile), @"mvc.1.0.view", @"/Views/Account/ViewProfile.cshtml")]
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
#line 1 "C:\Users\15821\Documents\GitHub\Training-Assignments\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\15821\Documents\GitHub\Training-Assignments\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\15821\Documents\GitHub\Training-Assignments\MovieShop\MovieShop.MVC\Views\Account\ViewProfile.cshtml"
using ApplicationCore.ServiceInterfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ed170e40032ff7810ec04de0564577f4627869", @"/Views/Account/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ed27a90769d57c4cf1e99ddf07e56b08d479e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>\r\n    Your Profile\r\n</h2>\r\n\r\n<hr />\r\n\r\n<h3>\r\n    User Name: ");
#nullable restore
#line 11 "C:\Users\15821\Documents\GitHub\Training-Assignments\MovieShop\MovieShop.MVC\Views\Account\ViewProfile.cshtml"
          Write(CurrentUserService.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n<h3>\r\n    User Email: ");
#nullable restore
#line 14 "C:\Users\15821\Documents\GitHub\Training-Assignments\MovieShop\MovieShop.MVC\Views\Account\ViewProfile.cshtml"
           Write(CurrentUserService.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICurrentUserService CurrentUserService { get; private set; }
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
