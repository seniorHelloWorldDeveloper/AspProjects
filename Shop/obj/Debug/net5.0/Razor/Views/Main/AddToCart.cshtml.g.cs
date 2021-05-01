#pragma checksum "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AddToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38581b8e1aef95d0a6c8e2e2ba0f8c42740a83fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_AddToCart), @"mvc.1.0.view", @"/Views/Main/AddToCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/AddToCart.cshtml", typeof(AspNetCore.Views_Main_AddToCart))]
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
#line 1 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AddToCart.cshtml"
using Shop;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38581b8e1aef95d0a6c8e2e2ba0f8c42740a83fb", @"/Views/Main/AddToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_AddToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pizza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AddToCart.cshtml"
  
    Layout = "../Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(78, 31, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(109, 3606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38581b8e1aef95d0a6c8e2e2ba0f8c42740a83fb4032", async() => {
                BeginContext(115, 3593, true);
                WriteLiteral(@"
        <title>Добавление товара в корзину</title>
        <style>
            body {
                padding: 20px;
                color: #373737;
                font-size: 62.5%;
                line-height: 2.0em;
            }

            *, *:before, *:after {
            -webkit-box-sizing: border-box;
            box-sizing: border-box;
            }


            legend {
            font-size: 16px;
            font-family: monospace;
            }

            input[type=checkbox] {
            opacity: 0;
            float:left;
            }

            input[type=checkbox] + label {
            margin: 0 0 0 20px;
            position: relative;
            cursor: pointer;
            font-size: 16px;
            font-family: monospace;
            float: left;
            }

            input[type=checkbox] + label ~ label {
            margin: 0 0 0 40px;
            }

            input[type=checkbox] + label::before {
            content: ' ';
  ");
                WriteLiteral(@"          position: absolute;
            left: -35px;
            top: -3px;
            width: 25px;
            height: 25px;
            display: block;
            background: white;
            border: 1px solid #A9A9A9;
            }

            input[type=checkbox] + label::after {
            content: ' ';
            position: absolute;
            left: -35px;
            top: -3px;
            width: 23px;
            height: 23px;
            display: block;
            z-index: 1;
            background: url('data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjE4MS4yIDI3MyAxNyAxNiIgZW5hYmxlLWJhY2tncm91bmQ9Im5ldyAxODEuMiAyNzMgMTcgMTYiPjxwYXRoIGQ9Ik0tMzA2LjMgNTEuMmwtMTEzLTExM2MtOC42LTguNi0yNC04LjYtMzQuMyAwbC01MDYuOSA1MDYuOS0yMTIuNC0yMTIuNGMtOC42LTguNi0yNC04LjYtMzQuMyAwbC0xMTMgMTEzYy04LjYgOC42LTguNiAyNCAwIDM0LjNsMjMxLjIgMjMxLjIgMTEzIDExM2M4LjYgOC42IDI0IDguNiAzNC4zIDBsMTEzLTExMyA1MjQtNTI0YzctMTAuMyA3LTI1LjctMS42LTM2eiIvPjxwYXRoIGZpbGw9IiMzN");
                WriteLiteral(@"zM3MzciIGQ9Ik0xOTcuNiAyNzcuMmwtMS42LTEuNmMtLjEtLjEtLjMtLjEtLjUgMGwtNy40IDcuNC0zLjEtMy4xYy0uMS0uMS0uMy0uMS0uNSAwbC0xLjYgMS42Yy0uMS4xLS4xLjMgMCAuNWwzLjMgMy4zIDEuNiAxLjZjLjEuMS4zLjEuNSAwbDEuNi0xLjYgNy42LTcuNmMuMy0uMS4zLS4zLjEtLjV6Ii8+PHBhdGggZD0iTTExODcuMSAxNDMuN2wtNTYuNS01Ni41Yy01LjEtNS4xLTEyLTUuMS0xNy4xIDBsLTI1My41IDI1My41LTEwNi4yLTEwNi4yYy01LjEtNS4xLTEyLTUuMS0xNy4xIDBsLTU2LjUgNTYuNWMtNS4xIDUuMS01LjEgMTIgMCAxNy4xbDExNC43IDExNC43IDU2LjUgNTYuNWM1LjEgNS4xIDEyIDUuMSAxNy4xIDBsNTYuNS01Ni41IDI2Mi0yNjJjNS4yLTMuNCA1LjItMTIgLjEtMTcuMXpNMTYzNC4xIDE2OS40bC0zNy43LTM3LjdjLTMuNC0zLjQtOC42LTMuNC0xMiAwbC0xNjkuNSAxNjkuNS03MC4yLTcxLjljLTMuNC0zLjQtOC42LTMuNC0xMiAwbC0zNy43IDM3LjdjLTMuNCAzLjQtMy40IDguNiAwIDEybDc3LjEgNzcuMSAzNy43IDM3LjdjMy40IDMuNCA4LjYgMy40IDEyIDBsMzcuNy0zNy43IDE3NC43LTE3Ni40YzEuNi0xLjcgMS42LTYuOS0uMS0xMC4zeiIvPjwvc3ZnPg==') no-repeat center center;
            -ms-transition: all .2s ease;
            -webkit-transition: all .2s ease;
            transition: all .3s ease;
            -ms-transform: scale(0);
 ");
                WriteLiteral(@"           -webkit-transform: scale(0);
            transform: scale(0);
            opacity: 0;
            }

            input[type=checkbox]:checked + label::after {
            -ms-transform: scale(1);
            -webkit-transform: scale(1);
            transform: scale(1);
            opacity: 1;
            }

            p, span, input[type=""number""]{
                font-size: 20px;
            }
            button{
                font-size: 16px;

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
            BeginContext(3715, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(3721, 1187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38581b8e1aef95d0a6c8e2e2ba0f8c42740a83fb8923", async() => {
                BeginContext(3727, 52, true);
                WriteLiteral("\r\n        <h2>Выбор добавок</h2>\r\n        <p>Пицца: ");
                EndContext();
                BeginContext(3780, 10, false);
#line 99 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AddToCart.cshtml"
             Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3790, 23, true);
                WriteLiteral("</p>\r\n        <p>Цена: ");
                EndContext();
                BeginContext(3814, 11, false);
#line 100 "C:\Users\Maxim\Desktop\AspProjects\Shop\Views\Main\AddToCart.cshtml"
            Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(3825, 14, true);
                WriteLiteral("</p>\r\n        ");
                EndContext();
                BeginContext(3839, 1056, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38581b8e1aef95d0a6c8e2e2ba0f8c42740a83fb10075", async() => {
                    BeginContext(3859, 1029, true);
                    WriteLiteral(@"
            <fieldset>
                <legend>Выбирайте добавки: </legend>
                <input type=""checkbox"" name=""maso"" id=""maso"" value=""true"">
                <label for=""maso"">Мясо</label>

                <input type=""checkbox"" name=""lychok"" id=""lychok"" value=""true"">
                <label for=""lychok"">Лук</label>

                <input type=""checkbox"" name=""tomats"" id=""tomats"" value=""true"">
                <label for=""tomats"">Томаты</label>
            </fieldset>
            <br>
            <br>
            <span>Сантиметры</span>
            <br>
            <br>
            <input type=""radio"" name=""centimeter"" value=""30"" >
            <span>30</span>
            <br>
            <input type=""radio"" name=""centimeter"" value=""50"">
            <span>50</span>
            <br>
            <br>
            <input type=""number"" min=""1"" name=""count"">
            <span>Кол-во</span>
            <br>
            <br>
            <button type=""submit"">В корзину</button>
   ");
                    WriteLiteral("     ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4895, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(4908, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
