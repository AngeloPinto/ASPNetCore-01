#pragma checksum "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\Admin\visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b92f94cf786c3e5c8f3e1864fe26372c2b353d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_visualizar), @"mvc.1.0.view", @"/Views/Admin/visualizar.cshtml")]
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
#line 1 "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\_ViewImports.cshtml"
using ASPCORE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\_ViewImports.cshtml"
using ASPCORE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b92f94cf786c3e5c8f3e1864fe26372c2b353d", @"/Views/Admin/visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80169653d50c37d4035190093297a1da772a0e12", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\Admin\visualizar.cshtml"
 if(!@ViewData["nome"].Equals("")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Olá Mundo! Seja bem vindo ");
#nullable restore
#line 3 "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\Admin\visualizar.cshtml"
                             Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("!!!</h1>\r\n");
#nullable restore
#line 4 "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\Admin\visualizar.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Olá Mundo! Você não informou seu nome :(</h1>\r\n");
#nullable restore
#line 6 "C:\Projects\Visual Studio\CSharp\ASPCORE\Views\Admin\visualizar.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
