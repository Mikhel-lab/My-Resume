#pragma checksum "C:\Users\SDSD\source\Mike-resume\BlazorApp.Resume.My\Pages\Aboutme.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1be804fda6b91fada54563f0dcc5be0a5c1e9efd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/about-me")]
    public partial class Aboutme : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><span class=\"oi oi-person\"></span> About me</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"card bg-dark text-white fade-in\">\r\n\t<img src=\"/images/geometricBg.jpg\" class=\"card-img\" alt=\"geometric\" style=\"height:1000px\">\r\n\t<div class=\"card-img-overlay\">\r\n\t\t<div class=\"text-justify\">\r\n\t\t\tHello! I\'m Michael Aiyetan, a <strong class=\"text-warning\">FULL STACK SOFTWARE Engineer</strong> with vast knowledge and experience in software development.\r\n\t\t\tI have always been amazed by how much computers can help automate and systemize simple tasks.\r\n\t\t\tFor the last 3 years, I have had elaborate experience in the software development ecosystem and currently working as a Software Developer for a Maritime company.\r\n\t\t\tOne of my biggest accomplishments within this role was helping to mastermind and develop an app for clients to help them track user’s data, enhancing monitoring and minimize costs.\r\n\t\t\tI still remain the one person that loves learning and putting into work my research results. Having a strong passion for growth and development has projected my thoughts via power-mind to accomplishment.\r\n\t\t\tI\'m a Machine Learning and AI Enthusiast.\r\n\t\t\tA Professor of Learning, a learning pro.\r\n\t\t</div>\r\n\t\t<div class=\"mt-2\">\r\n\t\t\t<ul class=\"nav nav-tabs\" id=\"myTab\" role=\"tablist\">\r\n\t\t\t\t<li class=\"nav-item btn-outline-dark\">\r\n\t\t\t\t\t<a class=\"nav-link active text-warning font-weight-bolder\" id=\"home-tab\" data-toggle=\"tab\" href=\"#home\" role=\"tab\" aria-controls=\"home\" aria-selected=\"true\">My Hobbies</a>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li class=\"nav-item btn-outline-dark\">\r\n\t\t\t\t\t<a class=\"nav-link text-warning font-weight-bolder\" id=\"contact-tab\" data-toggle=\"tab\" href=\"#contact\" role=\"tab\" aria-controls=\"contact\" aria-selected=\"false\">My Contacts</a>\r\n\t\t\t\t</li>\r\n\t\t\t</ul>\r\n\t\t\t<div class=\"tab-content\" id=\"myTabContent\">\r\n\t\t\t\t<div class=\"tab-pane fade show active\" id=\"home\" role=\"tabpanel\" aria-labelledby=\"home-tab\">\r\n\t\t\t\t\t<ul class=\"list-unstyled text-white mt-2\">\r\n\t\t\t\t\t\t<li class=\"media\">\r\n\t\t\t\t\t\t\t<span class=\"mt-2\"><i class=\"fa fa-leaf\"></i> Lecturing | Mentoring</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li class=\"media\">\r\n\t\t\t\t\t\t\t<span class=\"mt-2\"><i class=\"fa fa-leaf\"></i> Researching and Development [R&amp;D]</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li class=\"media\">\r\n\t\t\t\t\t\t\t<span class=\"mt-2\"><i class=\"fa fa-leaf\"></i> Studying</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li class=\"media\">\r\n\t\t\t\t\t\t\t<span class=\"mt-2\"><i class=\"fa fa-leaf\"></i> Travelling</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"tab-pane fade\" id=\"contact\" role=\"tabpanel\" aria-labelledby=\"contact-tab\">\r\n\t\t\t\t\t<div style=\"font-size:12px\" class=\"mt-2\">\r\n\t\t\t\t\t\t<div class=\"input-group mb-2 mr-sm-2\" style=\"font-size:12px\">\r\n\t\t\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t\t\t<div class=\"input-group-text text-danger\"><i class=\"fab fa-google\"></i></div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"gmail\" readonly value=\"michael.aiyetanjnr03@gmail.com\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"input-group mb-2 mr-sm-2\" style=\"font-size:12px\">\r\n\t\t\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t\t\t<div class=\"input-group-text text-danger\"><i class=\"fab fa-github\"></i></div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"github\" readonly value=\"https://github.com/Mikhel-lab\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"input-group mb-2 mr-sm-2\" style=\"font-size:12px\">\r\n\t\t\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t\t\t<div class=\"input-group-text text-primary\"><i class=\"fab fa-linkedin-in\"></i></div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"linkedin\" readonly value=\"https://www.linkedin.com/in/michael-aiyetan-jnr-6b3b60164/\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"input-group mb-2 mr-sm-2\" style=\"font-size:12px\">\r\n\t\t\t\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t\t\t\t<div class=\"input-group-text text-primary\"><i class=\"fa fa-mobile-alt\"></i></div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"mobile-number\" readonly value=\"(+234)-09064785439\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591