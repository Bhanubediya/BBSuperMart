#pragma checksum "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_details), @"mvc.1.0.view", @"/Views/Home/details.cshtml")]
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
#line 1 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\_ViewImports.cshtml"
using BBSuperMart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\_ViewImports.cshtml"
using BBSuperMart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d9", @"/Views/Home/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2114af77c1f2f24f1948fd8f93fe7e7e6cb5d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BBSuperMart.Models.ViewModels.DetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 7em; padding-top: 4.5em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" text-black-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 3em; padding-top: 4.5em"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("overflow-hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d96404", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d96666", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 3 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Products.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"row \">\r\n\r\n        <div class=\"col-6  \">\r\n            <div class=\"container\" >\r\n                <div class=\"border box-shadow text-center bg-light\" style=\"border-radius:1em;\">\r\n                    <img class=\"imageMain\"");
                BeginWriteAttribute("src", " src=\"", 386, "\"", 420, 1);
#nullable restore
#line 9 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 392, Model.Products.DetailImages, 392, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 421, "\"", 427, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"border box-shadow text-center d-inline-flex bg-light mt-3 pt-2 pb-2 \" style=\"border-radius: 1em; justify-content: space-around;\">\r\n                    <img class=\"w-25 img-thumbnail mr-2 ml-2\"");
                BeginWriteAttribute("src", " src=\"", 677, "\"", 704, 1);
#nullable restore
#line 12 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 683, Model.Products.image, 683, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 705, "\"", 711, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 712, "\"", 758, 3);
                WriteAttributeValue("", 722, "ImageUpdate(\'", 722, 13, true);
#nullable restore
#line 12 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 735, Model.Products.image, 735, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 756, "\')", 756, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <img class=\"w-25 img-thumbnail mr-2\"");
                BeginWriteAttribute("src", " src=\"", 820, "\"", 854, 1);
#nullable restore
#line 13 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 826, Model.Products.DetailImages, 826, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 855, "\"", 861, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 862, "\"", 915, 3);
                WriteAttributeValue("", 872, "ImageUpdate(\'", 872, 13, true);
#nullable restore
#line 13 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 885, Model.Products.DetailImages, 885, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 913, "\')", 913, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <img class=\"w-25 img-thumbnail mr-2\"");
                BeginWriteAttribute("src", " src=\"", 977, "\"", 1012, 1);
#nullable restore
#line 14 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 983, Model.Products.DetailImages1, 983, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1013, "\"", 1019, 0);
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 1020, "\"", 1074, 3);
                WriteAttributeValue("", 1030, "ImageUpdate(\'", 1030, 13, true);
#nullable restore
#line 14 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
WriteAttributeValue("", 1043, Model.Products.DetailImages1, 1043, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1072, "\')", 1072, 2, true);
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
            </div>
        </div>
        <div class=""col-6 border border bg-light "" style=""border-radius:1em;"">
            <div class=""container "" style=""background-image: url('')"">
                <h2 class=""pt-3 text-center text-secondary font-italic font-weight-bolder "">");
#nullable restore
#line 20 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                                                       Write(Model.Products.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                <hr />\r\n                <div class=\"d-inline-flex\">\r\n                    <div class=\" ml-2 mt-5 \" style=\"width:11em;height:3.4em;background-color:yellowgreen\">\r\n                        <div class=\"text-left text-white bg-dark\"");
                BeginWriteAttribute("style", " style=\"", 1654, "\"", 1662, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span class=""pr-4 pl-3 "" style=""font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif ""><strong>MRP</strong></span><strong style=""font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif ""> Quantity</strong></div>
                        <div class=""text-left pl-3""><span style=""padding-right:3.3em""><strong class=""text-dark "" style=""font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif "">₹</strong><span class=""text-dark text-right"">");
#nullable restore
#line 25 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                                                                                                                                                                                                                                       Write(Model.Products.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span><span class=\"pr-3 text-black-50  \" style=\"font-family:\'Trebuchet MS\', \'Lucida Sans Unicode\', \'Lucida Grande\', \'Lucida Sans\', Arial, sans-serif \">");
#nullable restore
#line 25 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.Products.quan_grams);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span></div>
                    </div>

                    <div class=""d-inline-flex"" style=""width:15em;padding-left:6em;"">
                        <div class=""text-center text-secondary pr-5 pl-5"" style=""padding-top:3.5em;""><i class=""fa-solid fa-square-plus fa-2x""id=""plus"" style=""cursor: pointer""></i></div>
                        <p style=""padding-top:3.5em;"">");
#nullable restore
#line 30 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                 Write(Model.Products.price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        <div class=""text-center pl-5 text-secondary"" style=""padding-top: 3.5em; ""><i class=""fa-solid fa-square-minus fa-2x""id=""minus"" style=""cursor: pointer""></i></div>
                    </div>

                </div>
                <div class=""d-inline-flex"">
                    <div class="" ml-2 mt-5 "" style=""width:10em;height:3.5em; background-color:lightcoral"">
                        <div class=""text-center text-white bg-dark""><strong>Shelf Life</strong></div>
                        <div class=""text-center""><span class=""text-black-50"">Check Package</span></div>
                    </div>
");
#nullable restore
#line 40 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                     if (Model.ExistsInCart)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d917200", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-minus btn btn-outline-danger\" style=\"cursor: pointer;\"> <span style=\"font-size:smaller;font-family:\'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif\">Remove</span></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                                WriteLiteral(Model.Products.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div   style=\"padding-left: 7em; padding-top: 4.5em\">\r\n                   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d920245", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-plus \" style=\"cursor: pointer;\"> <span style=\"font-size:smaller;font-family:\'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif\">Add to cart</span></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                                                              WriteLiteral(Model.Products.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ProductId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["ProductId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                     if (Model.Products.addToWishlist)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c71ad928e7d62546d36b9d3faa6f6f7e5c3e0d923310", async() => {
                    WriteLiteral("<i class=\"fa-solid fa-heart btn btn-outline-danger\" style=\"cursor: pointer\"> <span style=\"font-size:smaller;font-family:\'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif \">Wishlisted</span></i> ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                                                                  WriteLiteral(Model.Products.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <a style=""padding-left: 3em; padding-top: 4.5em""><i class=""fa-solid fa-heart btn btn-outline-warning"" style=""cursor: pointer""> <span style=""font-size:smaller;font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif "">Wishlist</span></i> </a>
");
#nullable restore
#line 58 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n                <h2 class=\"pt-5 pb-2 text-secondary\">Description</h2>\r\n                <p class=\"text-dark \">");
#nullable restore
#line 63 "C:\Users\Bhanu\Source\Repos\BBSuperMart\BBSuperMart\Views\Home\details.cshtml"
                                 Write(Model.Products.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function ImageUpdate(img) {\r\n            document.querySelector(\'.imageMain\').src = img;\r\n            \r\n        }\r\n\r\n        </script>\r\n");
            }
            );
            WriteLiteral(@"
 
<style>
    .img-thumbnail {
        cursor: pointer;
        border-radius: 5px;
        justify-content:space-between;
        
        
    }
    .img-thumbnail:hover{
        background-color:lightgray;
        
    }
    .imageMain {
        width: 23em;
        height: 23em;
    }
        .imageMain:hover {
            cursor: zoom-in;
            transform:scale(1.1);
            border-radius:5px;
           
        }
    #plus:hover {
        color: yellowgreen;
    }
    #minus:hover {
        color: orangered;
    }
   
</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BBSuperMart.Models.ViewModels.DetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
