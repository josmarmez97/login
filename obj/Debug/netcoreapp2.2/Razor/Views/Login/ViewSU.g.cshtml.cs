#pragma checksum "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff66a5d1bf1c89ee59894303c7e64981cedd545e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_ViewSU), @"mvc.1.0.view", @"/Views/Login/ViewSU.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/ViewSU.cshtml", typeof(AspNetCore.Views_Login_ViewSU))]
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
#line 1 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\_ViewImports.cshtml"
using login;

#line default
#line hidden
#line 2 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\_ViewImports.cshtml"
using login.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff66a5d1bf1c89ee59894303c7e64981cedd545e", @"/Views/Login/ViewSU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b40dcc6b8669af7a98162470d38c362acd51b15", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_ViewSU : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<login.Models.Usuarios>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
  
    ViewData["Title"]="WELCOME SU";

#line default
#line hidden
            BeginContext(80, 438, true);
            WriteLiteral(@"<div>
    <h2>Bienvenido SUPER USUARIO</h2>
    <h3>INDEX</h3>
    <a href=""Ingresa"" class=""btn btn-info"">Agregar</a>
     
    <table class=""table"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">USERID</th>
            <th scope=""col"">NOMBRE</th>
            <th scope=""col"">CONTRASEÑA</th>
            <th scope=""col"">PRIVILEGIOS</th>
            <th scope=""col"">OPCIONES</th>
        </tr>
");
            EndContext();
#line 19 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
     foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(563, 58, true);
            WriteLiteral("        <tr>                \r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(622, 7, false);
#line 22 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(629, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(665, 11, false);
#line 23 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
                       Write(item.Userid);

#line default
#line hidden
            EndContext();
            BeginContext(676, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(712, 11, false);
#line 24 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(723, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(759, 9, false);
#line 25 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
                       Write(item.Pass);

#line default
#line hidden
            EndContext();
            BeginContext(768, 88, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">XXXXXXXXXXXX</th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(857, 92, false);
#line 28 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
           Write(Html.ActionLink("Eliminar","Eliminar", new { id = @item.Id }, new{ @class="btn btn-danger"}));

#line default
#line hidden
            EndContext();
            BeginContext(949, 135, true);
            WriteLiteral("                    \r\n                <a href=\"Detalles\" class=\"btn btn-primary\">Actualizar</a>\r\n                <!--<a href=\"Eliminar/");
            EndContext();
            BeginContext(1085, 7, false);
#line 30 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
                                 Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 109, true);
            WriteLiteral("\" class=\"btn btn-danger\">X</a>-->\r\n            </th>                                   \r\n        </tr>     \r\n");
            EndContext();
#line 33 "D:\Instituto Tecnológico de Cancún\Metodologia de la prgramación\Unidad 2\proyecto final\login\Views\Login\ViewSU.cshtml"
         }    

#line default
#line hidden
            BeginContext(1217, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<login.Models.Usuarios>> Html { get; private set; }
    }
}
#pragma warning restore 1591
