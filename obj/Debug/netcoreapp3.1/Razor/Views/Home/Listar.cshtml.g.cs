#pragma checksum "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f378a714898bfb78951473d682d053cf4393125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar), @"mvc.1.0.view", @"/Views/Home/Listar.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\_ViewImports.cshtml"
using Studioarianearaujo_ATV5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\_ViewImports.cshtml"
using Studioarianearaujo_ATV5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f378a714898bfb78951473d682d053cf4393125", @"/Views/Home/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c1f3da1b6572c3a66d1a1cf4241541dcedd7038", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Atendimento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
  
    ViewData["Title"] = "Consulte agora mesmo os procedimentos realizados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>");
#nullable restore
#line 8 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n         <th>Cliente</th>\r\n         <th>Data</th>\r\n         <th>Procedimento</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
     foreach(Atendimento atend in Model){
    

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n          <td>");
#nullable restore
#line 20 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
         Write(atend.cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 21 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
         Write(atend.dataAtendimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 22 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
         Write(atend.procedimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <tr>\r\n         <td colspan=\"3\">Total de atendimentos solicitados: ");
#nullable restore
#line 28 "C:\Users\User\Desktop\Studioarianearaujo_ATV5\Views\Home\Listar.cshtml"
                                                       Write(Solicitacoes.Totalizar());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Atendimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
