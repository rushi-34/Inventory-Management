#pragma checksum "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7b3b0e2a03874d1442fd75d352d56dc0e2880c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Create), @"mvc.1.0.view", @"/Views/Bill/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7b3b0e2a03874d1442fd75d352d56dc0e2880c", @"/Views/Bill/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c82f77a7545a955816e3d4986e56270e8e0890f", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryManagementCore.Models.Models.Bill>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/addBill.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Bill/search.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Bill/handleData.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c7b3b0e2a03874d1442fd75d352d56dc0e2880c6451", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.6.0.min.js\" integrity=\"sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=\" crossorigin=\"anonymous\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7b3b0e2a03874d1442fd75d352d56dc0e2880c7730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7b3b0e2a03874d1442fd75d352d56dc0e2880c8769", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""errors"" style=""display: none""></div>
<div class=""product-quantity product-selling-price""></div>
<div class=""col mb-4"">
    <div class=""row-4"">
        <div class=""row"">
            <div class=""col-6  add-bill-upper-section add-bill-border-container"">
                <div class=""add-bill-search-customer"">
");
            WriteLiteral("                    <div class=\"col-6\">\r\n                        <input class=\"search-customer\" id=\"searchQueryInput\" type=\"text\" name=\"searchQueryInput\" placeholder=\"Search Customers\"");
            BeginWriteAttribute("value", " value=\"", 1188, "\"", 1196, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 200%; margin-left: -39%;"" />
                        <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px""
                             width=""24"" height=""24""
                             viewBox=""0 0 172 172""
                             style="" fill:#000000; display: inline; margin-top: -30%; margin-left: 140%;"">
                            <g fill=""none"" fill-rule=""nonzero"" stroke=""none"" stroke-width=""1"" stroke-linecap=""butt"" stroke-linejoin=""miter"" stroke-miterlimit=""10""");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 1698, "\"", 1717, 0);
            EndWriteAttribute();
            WriteLiteral(@" stroke-dashoffset=""0"" font-family=""none"" font-weight=""none"" font-size=""none"" text-anchor=""none"" style=""mix-blend-mode: normal"">
                                <path d=""M0,172v-172h172v172z"" fill=""none""></path>
                                <g fill=""#000000"">
                                    <path d=""M64.5,14.33333c-27.6214,0 -50.16667,22.54527 -50.16667,50.16667c0,27.6214 22.54527,50.16667 50.16667,50.16667c12.52732,0 23.97256,-4.67249 32.7819,-12.31771l3.05143,3.05143v9.26628l43,43l14.33333,-14.33333l-43,-43h-9.26628l-3.05143,-3.05143c7.64521,-8.80934 12.31771,-20.25458 12.31771,-32.7819c0,-27.6214 -22.54527,-50.16667 -50.16667,-50.16667zM64.5,28.66667c19.87509,0 35.83333,15.95824 35.83333,35.83333c0,19.87509 -15.95825,35.83333 -35.83333,35.83333c-19.87509,0 -35.83333,-15.95825 -35.83333,-35.83333c0,-19.87509 15.95824,-35.83333 35.83333,-35.83333z"">
                                    </path>
                                </g>
                            </g>
                        </svg>
 ");
            WriteLiteral("                   </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7b3b0e2a03874d1442fd75d352d56dc0e2880c12339", async() => {
                WriteLiteral("\r\n                        <button class=\"btn btn-success btn-add-product\" style=\"display: inline; margin-top: 23%; margin-left: 200%;\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Add New Customer\">+</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"add-bill-customer-overflow mt-3\">\r\n                    <ul class=\"list-group search-customers-list\">\r\n");
#nullable restore
#line 47 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
                          
                            foreach (var cust in ViewBag.CustomerDetails)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    <p style=\"display:inline\">");
#nullable restore
#line 51 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
                                                         Write(cust.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <span class=\"float-right\">\r\n                                        <button");
            BeginWriteAttribute("id", " id=\"", 3626, "\"", 3647, 1);
#nullable restore
#line 53 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
WriteAttributeValue("", 3631, cust.CustomerId, 3631, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"select-customer btn btn-sm btn-primary\">Select</button>\r\n                                    </span>\r\n                                </li>\r\n");
#nullable restore
#line 56 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-1\">\r\n                <p class=\"vertical_line\"></p>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"col-5 add-bill-upper-section add-bill-border-container\">\r\n");
            WriteLiteral("                <div class=\"col-6\">\r\n                    <input class=\"search-products\" id=\"searchQueryInput\" type=\"text\" name=\"searchQueryInput\" placeholder=\"Search Products\"");
            BeginWriteAttribute("value", " value=\"", 4609, "\"", 4617, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 231%; margin-left: -8%;"" />
                    <svg xmlns=""http://www.w3.org/2000/svg"" x=""0px"" y=""0px""
                         width=""24"" height=""24""
                         viewBox=""0 0 172 172""
                         style="" fill:#000000; display: inline; margin-top: -38%; margin-left: 196%;"">
                        <g fill=""none"" fill-rule=""nonzero"" stroke=""none"" stroke-width=""1"" stroke-linecap=""butt"" stroke-linejoin=""miter"" stroke-miterlimit=""10""");
            BeginWriteAttribute("stroke-dasharray", " stroke-dasharray=\"", 5098, "\"", 5117, 0);
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
     ");
            WriteLiteral("           <div");
            BeginWriteAttribute("class", " class=\"", 6157, "\"", 6165, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"add-bill-customer-overflow mt-3\">\r\n                        <ul class=\"list-group search-products-list\">\r\n\r\n");
#nullable restore
#line 89 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
                              
                                foreach (var product in ViewBag.ProductDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item\">\r\n                                        <p style=\"display:inline\">");
#nullable restore
#line 93 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
                                                             Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <span class=\"float-right\">\r\n                                            <button");
            BeginWriteAttribute("id", " id=\"", 6733, "\"", 6756, 1);
#nullable restore
#line 95 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"
WriteAttributeValue("", 6738, product.ProductId, 6738, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"select-product btn btn-sm btn-primary\">Select</button>\r\n                                        </span>\r\n                                    </li>\r\n");
#nullable restore
#line 98 "D:\SEM_5\WDDN\VisualStudionApplications\InventoryManagementCore\WDDN_DotNetCore_Project_CE022_CE045_CE046\InventoryManagementCore\Views\Bill\Create.cshtml"

                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <hr style=""border: 3px solid #28a745; width: 100%;"" />
    </div>
    <div class=""row "">
        <div class=""col-12 add-bill-border-container"">
            <div class=""row"">
                <div id=""cust-id"" style=""display:none"">-1</div>
                <div class=""col-9"">
                    <p class=""mt-1"">
                        <b>Customer Name:</b>
                        <span id=""cust-name""></span>
                    </p>
                </div>
                <div class=""col-3"">
                    <p class=""mt-1"">
                        <b>Phone No:</b>
                        <span id=""cust-phone-no""></span>
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-9"">
                    <p class=""mt-1"">
                        <b>Address:</b>
");
            WriteLiteral(@"                        <span id=""cust-address""></span>
                    </p>
                </div>
                <div class=""col-3"">
                    <p class=""mt-1"">
                        <b>Net Outstanding:</b>
                        <span id=""cust-net-outstanding""></span>
                    </p>
                </div>


            </div>

            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"" style=""display: none"">Sr. No</th>
                        <th scope=""col"">Product</th>
                        <th scope=""col"">Quantity</th>
                        <th scope=""col"">Selling Price</th>
                        <th scope=""col"">Total</th>
                        <th scope=""col"">Delete</th>
                    </tr>
                </thead>
                <tbody id=""product-items"">
                </tbody>
                <tfoot>
                    <tr>

                        <td><");
            WriteLiteral(@"b>Total Quatity:</b></td>
                        <td id=""finalQty"">0</td>
                        <td><b>Total Price:</b></td>
                        <td id=""finalTotal"">0</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan=""3"">
                            <div style=""display: flex; justify-content: space-evenly"">
                                <div class=""input-group input-group-sm mb-3"">
                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text"" id=""inputGroup-sizing-sm"" style=""height: 101%; border: 1px solid black""><b>Total Paid</b></span>
                                    </div>
                                    <input type=""number"" min=""0"" id=""totalPaid"" class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" style=""height: 132%; border: 1px solid black;"">
                ");
            WriteLiteral(@"                </div>
                            </div>
                        </td>
                        <td colspan=""3"">
                            <div style=""display: flex; justify-content: space-evenly"">
                                <button onclick=""handleMakeBill()"" class=""btn btn-success"" style=""width: 40%; height: 132%;"">Make Bill</button>
                            </div>
                        </td>

                    </tr>

                </tfoot>
            </table>
        </div>
    </div>
    <div class=""row"">
        <hr style=""border: 3px solid green; width: 100%;"" />
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryManagementCore.Models.Models.Bill> Html { get; private set; }
    }
}
#pragma warning restore 1591