#pragma checksum "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ebad2c0fc0756c2c4fed826778e4847441e392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\_ViewImports.cshtml"
using InventoryManagementCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\_ViewImports.cshtml"
using InventoryManagementCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\_ViewImports.cshtml"
using InventoryManagementCore.Models.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ebad2c0fc0756c2c4fed826778e4847441e392", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c82f77a7545a955816e3d4986e56270e8e0890f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventoryManagementCore.Models.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 2%; margin-left: 31%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Random"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50%; margin-left: 25%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn card-button btn-success view-product-update-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn card-button btn-danger view-product-delete-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n\r\n    <h1 class=\"col-4 display-4\" style=\"font-size:45px; padding: 0%; display: inline;\">View Products</h1>\r\n    <div class=\"col-6\">\r\n        <input id=\"searchQueryInput\" type=\"text\" name=\"searchQueryInput\" placeholder=\"Search\"");
            BeginWriteAttribute("value", " value=\"", 355, "\"", 363, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px""
             width=""24"" height=""24""
             viewBox=""0 0 172 172""
             style="" fill:#000000; display: inline; margin-top: -14%; margin-left: 95%;"">
            <g fill=""none"" fill-rule=""nonzero"" stroke=""none"" stroke-width=""1"" stroke-linecap=""butt"" stroke-linejoin=""miter"" stroke-miterlimit=""10""");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 744, "\"", 763, 0);
            EndWriteAttribute();
            WriteLiteral(@" stroke-dashoffset=""0"" font-family=""none"" font-weight=""none"" font-size=""none"" text-anchor=""none"" style=""mix-blend-mode: normal"">
                <path d=""M0,172v-172h172v172z"" fill=""none""></path>
                <g fill=""#000000"">
                    <path d=""M64.5,14.33333c-27.6214,0 -50.16667,22.54527 -50.16667,50.16667c0,27.6214 22.54527,50.16667 50.16667,50.16667c12.52732,0 23.97256,-4.67249 32.7819,-12.31771l3.05143,3.05143v9.26628l43,43l14.33333,-14.33333l-43,-43h-9.26628l-3.05143,-3.05143c7.64521,-8.80934 12.31771,-20.25458 12.31771,-32.7819c0,-27.6214 -22.54527,-50.16667 -50.16667,-50.16667zM64.5,28.66667c19.87509,0 35.83333,15.95824 35.83333,35.83333c0,19.87509 -15.95825,35.83333 -35.83333,35.83333c-19.87509,0 -35.83333,-15.95825 -35.83333,-35.83333c0,-19.87509 15.95824,-35.83333 35.83333,-35.83333z"">
                    </path>
                </g>
            </g>
        </svg>
    </div>
    <p class=""col-2"" style=""margin-top:1%"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6ebad2c0fc0756c2c4fed826778e4847441e3929829", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </p>
</div>
<hr class=""bg-secondary"" style=""border: 2px solid #6c757d;"" />

<style>
    .card {
        box-shadow: 0 12px 16px 0 rgba(0, 0, 0, 0.2);
        max-width: 300px;
        margin: auto;
        margin-top: 3%;
        padding: 0px;
        text-align: center;
        font-family: arial;
    }

    .card-button {
        border: none;
        outline: 0;
        padding: 12px;
        color: white;
        background-color: rgb(0, 0, 0);
        text-align: center;
        cursor: pointer;
        width: 100%;
        font-size: 18px;
    }

        .card-button:hover {
            opacity: 0.8;
        }

    .card-img-top {
        width: 100%;
        height: 164px;
        object-fit: cover
    }
</style>

<div class="" row"">

");
#nullable restore
#line 66 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {
        var photoPath = "~/Images/" + (item.ProductPhotoPath ?? "DefaultProductImage.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-4\" id=\"Products-Card\">\r\n");
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6ebad2c0fc0756c2c4fed826778e4847441e39212459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                               WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 71 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <ul class=\"list-group list-group-flush\"");
            BeginWriteAttribute("id", " id=\"", 3122, "\"", 3142, 1);
#nullable restore
#line 72 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
WriteAttributeValue("", 3127, item.ProductId, 3127, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <li class=\"list-group-item\"><b>");
#nullable restore
#line 73 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                          Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 73 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                <li class=\"list-group-item\"><b>");
#nullable restore
#line 74 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                          Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 74 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                <li class=\"list-group-item\"><b>");
#nullable restore
#line 75 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                          Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 75 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                <li class=\"list-group-item\"><b>");
#nullable restore
#line 76 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                          Write(Html.DisplayNameFor(model => model.BuyingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(": &#x20b9 ");
#nullable restore
#line 76 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                                                                                    Write(Html.DisplayFor(modelItem => item.BuyingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                <li class=\"list-group-item\"><b>");
#nullable restore
#line 77 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                          Write(Html.DisplayNameFor(model => model.SellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(": &#x20b9 ");
#nullable restore
#line 77 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                                                                                     Write(Html.DisplayFor(modelItem => item.SellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n            </ul>\r\n            <div class=\"btn-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6ebad2c0fc0756c2c4fed826778e4847441e39219745", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6ebad2c0fc0756c2c4fed826778e4847441e39222078", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
                                         WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 84 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventoryManagementCore.Models.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591