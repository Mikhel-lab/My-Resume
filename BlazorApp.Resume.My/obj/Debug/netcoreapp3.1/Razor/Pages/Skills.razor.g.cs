#pragma checksum "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\Pages\Skills.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4210cdb90ddd585f67c9cdbfb02e49761bccffd3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Resume.My.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using BlazorApp.Resume.My;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\_Imports.razor"
using BlazorApp.Resume.My.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/my-skills")]
    public partial class Skills : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><span class=\"oi oi-key\"></span> Skills</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"fade-in\">\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-6\">\r\n\t\t\t<img src=\"/images/skills_quote1.jpg\" style=\"height:auto; width:100%\">\r\n\t\t</div>\r\n\t\t<div class=\"col-6\">\r\n\t\t\t<img src=\"/images/skills_quote.jpg\" style=\"height:auto; width:100%\">\r\n\t\t</div>\r\n\t</div>\r\n\t<hr>\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-danger btn-block h2 card-body font-weight-bold shadow\">C#</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-danger btn-block h2 card-body font-weight-bold shadow\">ASP.NET</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-danger btn-block h2 card-body font-weight-bold shadow\">ASP.NET CORE</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-danger btn-block h2 card-body font-weight-bold shadow\">ASP.NET MVC</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-info btn-block h2 card-body font-weight-bold shadow\">Azure DevOps</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-info btn-block h2 card-body font-weight-bold shadow\">Xamarin</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-info btn-block h2 card-body font-weight-bold shadow\">Web API Development - REST</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-info btn-block h2 card-body font-weight-bold shadow\">Entity Framework [EF]</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-primary btn-block h2 card-body font-weight-bold shadow\">HTML5</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-primary btn-block h2 card-body font-weight-bold shadow\">CSS</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-primary btn-block h2 card-body font-weight-bold shadow\">Bootstrap</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-primary btn-block h2 card-body font-weight-bold shadow\">Javascript</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-dark btn-block h2 card-body font-weight-bold shadow\">Jquery</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-dark btn-block h2 card-body font-weight-bold shadow\">SQL Server Management Studio</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-dark btn-block h2 card-body font-weight-bold shadow\">SQL Server</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-dark btn-block h2 card-body font-weight-bold shadow\">MySQL</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-secondary btn-block h2 card-body font-weight-bold shadow\">SQLite</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-secondary btn-block h2 card-body font-weight-bold shadow\">MongoDB</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-secondary btn-block h2 card-body font-weight-bold shadow\">NPOCO</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-secondary btn-block h2 card-body font-weight-bold shadow\">Language Integrate Query (LINQ)</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-danger btn-block h2 card-body font-weight-bold shadow\">Nuget Development [Library Hosting]</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-secondary btn-block h2 card-body font-weight-bold shadow\">Desktop Publishing</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-danger btn-block h2 card-body font-weight-bold shadow\">WordPress</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-primary btn-block h2 card-body font-weight-bold shadow\">SOLID Design Principle</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-info btn-block h2 card-body font-weight-bold shadow\">Blazor [Front-end framework]</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-danger btn-block h2 card-body font-weight-bold shadow\">Angular</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-info btn-block h2 card-body font-weight-bold shadow\">Mentoring</button>\r\n\t\t</div>\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t<button class=\"btn btn-outline-success btn-block h2 card-body font-weight-bold shadow\">Teaching</button>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
