#pragma checksum "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dddf6662a3724713508c3fba38da1acf715aefc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dddf6662a3724713508c3fba38da1acf715aefc", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FitComrade.Models.Accounts>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
           Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 977, "\"", 1000, 1);
#nullable restore
#line 40 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
WriteAttributeValue("", 992, item.ID, 992, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1053, "\"", 1076, 1);
#nullable restore
#line 41 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
WriteAttributeValue("", 1068, item.ID, 1068, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1131, "\"", 1154, 1);
#nullable restore
#line 42 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
WriteAttributeValue("", 1146, item.ID, 1146, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\jurge\Documents\MEGAsync\Laptop\Fontys\Semester 2\Project\FitComradeWebshop\FitComrade\Views\Home\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FitComrade.Models.Accounts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
