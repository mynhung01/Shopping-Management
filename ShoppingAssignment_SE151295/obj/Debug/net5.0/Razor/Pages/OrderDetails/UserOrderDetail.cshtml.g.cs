#pragma checksum "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa2656568bd9447e65a5decfb434b743b74a228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingAssignment_SE151295.Pages.OrderDetails.Pages_OrderDetails_UserOrderDetail), @"mvc.1.0.razor-page", @"/Pages/OrderDetails/UserOrderDetail.cshtml")]
namespace ShoppingAssignment_SE151295.Pages.OrderDetails
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
#line 1 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\_ViewImports.cshtml"
using ShoppingAssignment_SE151295;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa2656568bd9447e65a5decfb434b743b74a228", @"/Pages/OrderDetails/UserOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142779ad4241071b6a055d2c8464e120355c152b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OrderDetails_UserOrderDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Orders/UserOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
  
    ViewData["Title"] = "UserOrderDetail";
    Layout = "~/Pages/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body {\r\n        background-color: #f5faf9;\r\n    }\r\n</style>\r\n<h1>UserOrderDetail</h1>\r\n\r\n<table class=\"table\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9aa2656568bd9447e65a5decfb434b743b74a2284621", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Customer.ContactName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
 foreach (var item in Model.OrderDetail) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 50 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
                  
                    Model.Price = item.UnitPrice * item.Quantity;
                    Model.totalPrice += Model.Price;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 54 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <h1>Total Order: ");
#nullable restore
#line 66 "C:\CODE\ShoppingAssignment_SE151295\ShoppingAssignment_SE151295\Pages\OrderDetails\UserOrderDetail.cshtml"
                Write(Model.totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa2656568bd9447e65a5decfb434b743b74a22810914", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingAssignment_SE151295.Pages.OrderDetails.UserOrderDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShoppingAssignment_SE151295.Pages.OrderDetails.UserOrderDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShoppingAssignment_SE151295.Pages.OrderDetails.UserOrderDetailModel>)PageContext?.ViewData;
        public ShoppingAssignment_SE151295.Pages.OrderDetails.UserOrderDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
