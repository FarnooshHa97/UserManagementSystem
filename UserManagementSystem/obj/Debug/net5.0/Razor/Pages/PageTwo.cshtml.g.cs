#pragma checksum "C:\Users\farnoosh\source\repos\UserManagementSystem\UserManagementSystem\Pages\PageTwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2c325eb7fa851c14eb10f4a91e6e5f83d1b21a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UserManagementSystem.Pages.Pages_PageTwo), @"mvc.1.0.razor-page", @"/Pages/PageTwo.cshtml")]
namespace UserManagementSystem.Pages
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
#line 1 "C:\Users\farnoosh\source\repos\UserManagementSystem\UserManagementSystem\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\farnoosh\source\repos\UserManagementSystem\UserManagementSystem\Pages\_ViewImports.cshtml"
using UserManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\farnoosh\source\repos\UserManagementSystem\UserManagementSystem\Pages\_ViewImports.cshtml"
using UserManagementSystem.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2c325eb7fa851c14eb10f4a91e6e5f83d1b21a", @"/Pages/PageTwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a2d817cbe45e952b664b43ba952bf785e2ff30", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PageTwo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\farnoosh\source\repos\UserManagementSystem\UserManagementSystem\Pages\PageTwo.cshtml"
  
    ViewData["Title"] = "Page two";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\farnoosh\source\repos\UserManagementSystem\UserManagementSystem\Pages\PageTwo.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserManagementSystem.Pages.PageTwoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserManagementSystem.Pages.PageTwoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserManagementSystem.Pages.PageTwoModel>)PageContext?.ViewData;
        public UserManagementSystem.Pages.PageTwoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
