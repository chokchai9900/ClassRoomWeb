#pragma checksum "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99df7da49b3162f8d9fa0894e5e6fc6911be58f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClassRoom_Details), @"mvc.1.0.view", @"/Views/ClassRoom/Details.cshtml")]
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
#line 1 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\_ViewImports.cshtml"
using ClassRoomWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\_ViewImports.cshtml"
using ClassRoomWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99df7da49b3162f8d9fa0894e5e6fc6911be58f1", @"/Views/ClassRoom/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb27b68bc0b92ded739d536800efccd3eacc56e1", @"/Views/_ViewImports.cshtml")]
    public class Views_ClassRoom_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassRoomWeb.Models.ClassRoomModel>
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
#line 3 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4> ");
#nullable restore
#line 10 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
    Write(Html.DisplayFor(model => model.classRoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.classRoomId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayFor(model => model.classRoomId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dd class=\"col-sm-2\">\r\n            Qr code\r\n        </dd>\r\n        <dt class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 543, "\"", 569, 1);
#nullable restore
#line 24 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
WriteAttributeValue("", 549, ViewBag.QRCodeImage, 549, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </dt>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.classRoomDiscription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayFor(model => model.classRoomDiscription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.classRoomSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayFor(model => model.classRoomSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.createAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
       Write(Html.DisplayFor(model => model.createAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    \r\n    \r\n    <h4>");
#nullable restore
#line 49 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
   Write(Html.DisplayNameFor(it => it.classTeacher));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Teacher Name
                </th>
                <th>
                    Teacher Tel.
                </th>
                <th>
                    Subject
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 67 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
             foreach (var item in Model.classTeacher)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.teacherId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.teacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.teacherTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.subjectTaught));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 83 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n     <h4>");
#nullable restore
#line 90 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
    Write(Html.DisplayNameFor(it => it.classStudent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Student Id
                </th>
                <th>
                    Student Name
                </th>
                <th>
                    Check-In Time
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 107 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
             foreach (var item in Model.classStudent)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 111 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.studentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 114 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.studentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 117 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.checkInAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 120 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 126 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.classRoomId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 127 "C:\Users\BloodRainz\source\repos\ClassRoomWeb\ClassRoomWeb\Views\ClassRoom\Details.cshtml"
Write(Html.ActionLink("Check In", "checkIn", new { id = Model.classRoomId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99df7da49b3162f8d9fa0894e5e6fc6911be58f112940", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassRoomWeb.Models.ClassRoomModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
