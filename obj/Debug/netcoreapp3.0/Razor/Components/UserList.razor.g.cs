#pragma checksum "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a37ae2217d60bfdcfc4c9501136bd83343fbc490"
// <auto-generated/>
#pragma warning disable 1591
namespace retaurant_info.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 3 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
using retaurant_info.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
using retaurant_info.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
using retaurant_info.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UserList</h3>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
 foreach (var item in Users.GetUsers())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "\r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "h5");
            __builder.AddAttribute(9, "class", "card-title");
            __builder.AddContent(10, 
#nullable restore
#line 26 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
                                    item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<div class=\"card-footer\">\r\n            <small class=\"text-muted\"><button data-toggle=\"modal\" value=\"More Info\" class=\"btn btn-primary\">More Info</button></small>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 32 "C:\Users\joao2\OneDrive\Documentos\retaurant-info\Components\UserList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private retaurant_info.Services.UserServices Users { get; set; }
    }
}
#pragma warning restore 1591
