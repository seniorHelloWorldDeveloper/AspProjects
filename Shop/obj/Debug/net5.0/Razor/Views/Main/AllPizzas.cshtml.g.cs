#pragma checksum "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dad371902b0945ec40fe286a2b15ef915a16f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_AllPizzas), @"mvc.1.0.view", @"/Views/Main/AllPizzas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/AllPizzas.cshtml", typeof(AspNetCore.Views_Main_AllPizzas))]
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
#line 1 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
using Shop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dad371902b0945ec40fe286a2b15ef915a16f60", @"/Views/Main/AllPizzas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_AllPizzas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pizza>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
  
    Layout = "../Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(118, 3848, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dad371902b0945ec40fe286a2b15ef915a16f603362", async() => {
                BeginContext(124, 17, true);
                WriteLiteral("\r\n        <title>");
                EndContext();
                BeginContext(142, 26, false);
#line 9 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
          Write(Model.First().CategoryName);

#line default
#line hidden
                EndContext();
                BeginContext(168, 3791, true);
                WriteLiteral(@"</title>
        <style>
            .gallery{
                overflow: hidden;
                width: 480px;
            }
            .gallery .ramka{
                float: left;
                margin-right: 10px;
                margin-bottom: 10px;
            }
            .gallery img{
                width: 150px; height: 150px; object-fit: cover;
            }
            body{
                max-width: 1000px;
                margin: 0 auto;
                margin-top: 40px;
            }
            .product-grid{
                font-family: 'Open Sans', sans-serif;
                text-align: center;
            }
            .product-grid .product-image{
                position: relative;
                overflow: hidden;
            }
            .product-grid .product-image img{
                width: 100%;
                height: auto;
                transition: all 0.3s;
            }
            .product-grid .product-image:hover img{ transform: scale(1.");
                WriteLiteral(@"05); }
            .product-grid .product-new-label{
                color: #fff;
                background: #cd1b29;
                font-size: 12px;
                font-weight: 600;
                text-transform: uppercase;
                padding: 3px 10px 10px;
                position: absolute;
                top: 0px;
                left: 0;
                clip-path: polygon(0 0, 100% 0, 100% 75%, 15% 75%, 0 100%, 0% 25%);
            }
            .product-grid .product-content{
                width: 100%;
                padding: 12px 0;
                display: inline-block;
            }
            .product-grid .price{
                color: #000;
                font-size: 16px;
                font-weight: 600;
                width: calc(100% - 100px);
                margin: 0 0 10px;
                display: inline-block;
            }
            .product-grid .price span{
                color: #7a7a7a;
                font-size: 15px;
                ma");
                WriteLiteral(@"rgin-right: 5px;
                display: inline-block;

            }
            .product-grid .add-to-cart{
                font-size: 13px;
                font-weight: 600;
                width: 75%;
                margin: 0 auto;
                border: 1px solid #033772;
                display: block;
                transition: all .3s ease;
            }
            .product-grid .add-to-cart i{
                text-align: center;
                line-height: 35px;
                height: 35px;
                width: 35px;
                display: inline-block;
            }
            .product-grid .add-to-cart span{
                text-align: center;
                line-height: 35px;
                height: 35px;
                width: calc(100% - 40px);
                padding: 0 6px;
                vertical-align: top;
                display: inline-block;
            }
            .product-title {
                font-weight: normal;
                color: ");
                WriteLiteral(@"#162546;
                font-size: 18px;
            }
            a:visited{
                color: white;
            }
            a:active{
                color: white;
            }
            a{
                display: inline-block;
                background-color: #ff7659;
                margin-top: 10px;
                color: white;
                height: 50px;
                text-align: center;
                text-decoration: none;
                padding-top: 9px;
                padding-left: 4px;
                padding-right: 4px;
                font-size: 20px;
            }
            a:hover{
                color: white;
            }
        </style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3966, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(3972, 1182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dad371902b0945ec40fe286a2b15ef915a16f608814", async() => {
                BeginContext(3978, 70, true);
                WriteLiteral("\r\n        <div class=\"container\">\r\n                <div class=\"row\">\r\n");
                EndContext();
#line 131 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
                     foreach (var item in Model){
                        

#line default
#line hidden
#line 132 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
                         if (item.IsOnMainPage){

#line default
#line hidden
                BeginContext(4149, 244, true);
                WriteLiteral("                            <div class=\"col-md-3 col-sm-6\">\r\n                                <div class=\"product-grid\">\r\n                                    <div class=\"product-image\">\r\n                                        <img class=\"pic-1\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4393, "\"", 4410, 1);
#line 136 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
WriteAttributeValue("", 4399, item.Image, 4399, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4411, 213, true);
                WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"product-content\">\r\n                                    <div class=\"product-title\">");
                EndContext();
                BeginContext(4625, 9, false);
#line 140 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4634, 63, true);
                WriteLiteral("</div>\r\n                                    <div class=\"price\">");
                EndContext();
                BeginContext(4698, 24, false);
#line 141 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
                                                  Write(item.Price.ToString("c"));

#line default
#line hidden
                EndContext();
                BeginContext(4722, 66, true);
                WriteLiteral("</div>\r\n                                    <a class=\"add-to-cart\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4788, "\"", 4814, 2);
                WriteAttributeValue("", 4795, "/AddToCart/", 4795, 11, true);
#line 142 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
WriteAttributeValue("", 4806, item.Id, 4806, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4815, 208, true);
                WriteLiteral(">\r\n                                        <span class=\"span\">Добавить в корзину</span>\r\n                                    </a> \r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 147 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
                        
                        }

#line default
#line hidden
#line 148 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AllPizzas.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(5099, 48, true);
                WriteLiteral("                </div>\r\n            </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5154, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
