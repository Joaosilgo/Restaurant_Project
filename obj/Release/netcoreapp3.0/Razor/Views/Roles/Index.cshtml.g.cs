#pragma checksum "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cdb9b9d9b6650d7d1663074962e1c5487a1f441"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
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
#line 1 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\_ViewImports.cshtml"
using retaurant_info;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\_ViewImports.cshtml"
using retaurant_info.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdb9b9d9b6650d7d1663074962e1c5487a1f441", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5beed08303ce8538f35dd178c5292bf6df066fe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<retaurant_info.Controllers.RolesController.DisplayViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddUserToRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n\r\n<h2>Create User</h2>\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cdb9b9d9b6650d7d1663074962e1c5487a1f4415827", async() => {
                WriteLiteral("\r\n\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cdb9b9d9b6650d7d1663074962e1c5487a1f4416109", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 23 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label>Email</label>\r\n                    <input name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 521, "\"", 529, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" />
                    <span class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-4\">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
             foreach (var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card p-3  text-muted bg-white rounded\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"lead\"> ");
#nullable restore
#line 42 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                                    Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n    </div>\r\n    <hr />\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cdb9b9d9b6650d7d1663074962e1c5487a1f44111001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 61 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new  retaurant_info.Controllers.RolesController.RoleViewModel();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    <hr />\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cdb9b9d9b6650d7d1663074962e1c5487a1f44112665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 66 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new retaurant_info.Controllers.RolesController.UpdateUserRoleViewModel() { Users = Model.Users, Roles = Model.Roles };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <hr />\r\n\r\n    <div>\r\n        <div>\r\n            <h2>Role List</h2>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
             foreach (var role in Model.Roles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card p-3  text-muted bg-white rounded\">\r\n                    <div class=\"card-body\">\r\n                        <p class=\"lead\"> ");
#nullable restore
#line 79 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                                    Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 83 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n            <h2>Users Role List</h2>\r\n\r\n");
#nullable restore
#line 89 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
             foreach (var users in Model.Users)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                 if (users.Roles.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card p-3  text-muted bg-white rounded\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 95 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                                              Write(users.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\r\n");
#nullable restore
#line 98 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                             foreach (var item in users.Roles.ToList())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"lead\"> ");
#nullable restore
#line 100 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"lead\"> ");
#nullable restore
#line 101 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 102 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 109 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Views\Roles\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<retaurant_info.Controllers.RolesController.DisplayViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
