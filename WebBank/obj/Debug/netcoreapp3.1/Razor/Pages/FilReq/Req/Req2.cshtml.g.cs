#pragma checksum "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0018035a5433d43e6e354dc2eaaccb67bc0a2f44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebBank.Pages.FilReq.Req.Pages_FilReq_Req_Req2), @"mvc.1.0.razor-page", @"/Pages/FilReq/Req/Req2.cshtml")]
namespace WebBank.Pages.FilReq.Req
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
#line 1 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\_ViewImports.cshtml"
using WebBank;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0018035a5433d43e6e354dc2eaaccb67bc0a2f44", @"/Pages/FilReq/Req/Req2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d8d0d6bff10368cd6827b92d9023d6bce4067e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Req_Req2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Вклады</h1>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 10 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
               Write(Html.DisplayNameFor(model => model.Deposit[0].DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
               Write(Html.DisplayNameFor(model => model.Deposit[0].CurId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
             foreach (var item in Model.Deposit)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 26 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
                          
                            try
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
                           Write(Model.Currency.First(r => r.CurId == item.CurId).Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
                                                                                      
                            }
                            catch
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p> Данных нет </p>\r\n");
#nullable restore
#line 34 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Даша\Source\Repos\Kust\WebBank\WebBank\Pages\FilReq\Req\Req2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBank.Pages.FilReq.Req.Req2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebBank.Pages.FilReq.Req.Req2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebBank.Pages.FilReq.Req.Req2Model>)PageContext?.ViewData;
        public WebBank.Pages.FilReq.Req.Req2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591