#pragma checksum "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f176188576a277421867427dbf4ef5e6d4735a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schools_Geld), @"mvc.1.0.view", @"/Views/Schools/Geld.cshtml")]
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
#line 1 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\_ViewImports.cshtml"
using RekenTrainer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\_ViewImports.cshtml"
using RekenTrainer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f176188576a277421867427dbf4ef5e6d4735a", @"/Views/Schools/Geld.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02754155db6b72596159202ba3fc47d48373021", @"/Views/_ViewImports.cshtml")]
    public class Views_Schools_Geld : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RekenTrainer.Models.School>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-4 card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Schools", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Optellen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aftrekken", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Geld", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Meten", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Vermenigvuldigen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Percentage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
  
    ViewData["Title"] = "Geld";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Online Rekenen Oefenen</h1>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2 pt-4 bg-light rounded\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a6631", async() => {
                WriteLiteral("Optellen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a8089", async() => {
                WriteLiteral("Aftrekken");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a9548", async() => {
                WriteLiteral("Geld");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a11002", async() => {
                WriteLiteral("Meten");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a12458", async() => {
                WriteLiteral("Delen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a13914", async() => {
                WriteLiteral("Vermenigvuldigen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a15381", async() => {
                WriteLiteral("Percentage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-10\">\r\n");
#nullable restore
#line 20 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"border border-primary rounded m-4 p-2\">\r\n                        <div class=\"row\">\r\n                            <h5 class=\"text-black ml-3\">");
#nullable restore
#line 26 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                                                   Write(item.Qid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ) ");
#nullable restore
#line 26 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                                                               Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2 ml-5\">\r\n                                <input type=\"radio\" id=\"optie1\"");
            BeginWriteAttribute("name", " name=\"", 1478, "\"", 1498, 1);
#nullable restore
#line 30 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 1485, item.Option1, 1485, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 1510, "\"", 1531, 1);
#nullable restore
#line 30 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 1518, item.Option1, 1518, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                ");
#nullable restore
#line 31 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                           Write(item.Option1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-2 ml-5\">\r\n                                <input type=\"radio\" id=\"optie1\"");
            BeginWriteAttribute("name", " name=\"", 1737, "\"", 1757, 1);
#nullable restore
#line 34 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 1744, item.Option2, 1744, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 1769, "\"", 1790, 1);
#nullable restore
#line 34 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 1777, item.Option2, 1777, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                ");
#nullable restore
#line 35 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                           Write(item.Option2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-2 ml-5\">\r\n                                <input type=\"radio\" id=\"optie1\"");
            BeginWriteAttribute("name", " name=\"", 1996, "\"", 2016, 1);
#nullable restore
#line 38 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 2003, item.Option3, 2003, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 2028, "\"", 2049, 1);
#nullable restore
#line 38 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 2036, item.Option3, 2036, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                ");
#nullable restore
#line 39 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                           Write(item.Option3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-2 ml-5\">\r\n                                <input type=\"radio\" id=\"optie1\"");
            BeginWriteAttribute("name", " name=\"", 2255, "\"", 2275, 1);
#nullable restore
#line 42 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 2262, item.Option4, 2262, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\"");
            BeginWriteAttribute("value", " value=\"", 2287, "\"", 2308, 1);
#nullable restore
#line 42 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 2295, item.Option4, 2295, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                ");
#nullable restore
#line 43 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                           Write(item.Option4);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"ml-3\">\r\n                                <label id=\"Corrigeert\"");
            BeginWriteAttribute("name", " name=\"", 2574, "\"", 2597, 1);
#nullable restore
#line 48 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
WriteAttributeValue("", 2581, item.Correctans, 2581, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rb\" style=\"display: none; color: forestgreen;\"><b>Het juiste antwoord is \'");
#nullable restore
#line 48 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                                                                                                                                                           Write(item.Correctans);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'</b></label>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
                 

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Oeps er is iets mis gegaan</p>\r\n");
#nullable restore
#line 58 "C:\Users\Mike\source\repos\RekenTrainer\RekenTrainer\Views\Schools\Geld.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" id=\"btn\" class=\"btn btn-success\">Verzenden</button>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f176188576a277421867427dbf4ef5e6d4735a24869", async() => {
                WriteLiteral("Reset");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous""></script>

<script>
    $(document).ready(function () {
        $(""#btn"").click(function () {
            $("".rb"").show();
            $("".rb"").attr(""disabled"", true);
        });
    });


</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RekenTrainer.Models.School>> Html { get; private set; }
    }
}
#pragma warning restore 1591
