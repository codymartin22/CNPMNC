#pragma checksum "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e07c80e82893bd037fd7a47f43acce2591ba11c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_WeatherInfo), @"mvc.1.0.view", @"/Views/Shared/WeatherInfo.cshtml")]
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
#line 1 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\_ViewImports.cshtml"
using LoginGoogle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\_ViewImports.cshtml"
using LoginGoogle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e07c80e82893bd037fd7a47f43acce2591ba11c", @"/Views/Shared/WeatherInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d8d9c525eee43550d760aa662c4020ae2b78e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_WeatherInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 3 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
         if (@ViewBag.Flag == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-header\"  style=\"background-color:grey\">\r\n                        <h5 class=\"title\">Weather of ");
#nullable restore
#line 8 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                                Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <img");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 339, 1);
#nullable restore
#line 8 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 319, ViewBag.CountryFlag, 319, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", " disabled=\"", 340, "\"", 351, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:40px;height:40px\"");
            BeginWriteAttribute("value", " value=\"", 383, "\"", 411, 1);
#nullable restore
#line 8 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 391, ViewBag.CountryName, 391, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></h5>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e07c80e82893bd037fd7a47f43acce2591ba11c4932", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-3 pr-1"">
                                    <div class=""form-group"">
                                        <label id=""TemperatureLB"">Temperature</label>
                                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("disabled", " disabled=\"", 863, "\"", 874, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 875, "\"", 899, 2);
#nullable restore
#line 16 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 883, ViewBag.Temp, 883, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 896, "°C", 897, 3, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-2 px-1"">
                                    <div class=""form-group"">
                                        <label>Temperature Min</label>
                                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("disabled", " disabled=\"", 1261, "\"", 1272, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1273, "\"", 1300, 2);
#nullable restore
#line 22 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 1281, ViewBag.TempMin, 1281, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1297, "°C", 1298, 3, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-2 px-1"">
                                    <div class=""form-group"">
                                        <label>Temperature Max</label>
                                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("disabled", " disabled=\"", 1662, "\"", 1673, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1674, "\"", 1701, 2);
#nullable restore
#line 28 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 1682, ViewBag.TempMax, 1682, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1698, "°C", 1699, 3, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-2 px-1"">
                                    <div class=""form-group"">
                                        <label>Humidity</label>
                                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("disabled", " disabled=\"", 2056, "\"", 2067, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2068, "\"", 2091, 2);
#nullable restore
#line 34 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 2076, ViewBag.Humi, 2076, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2089, "%", 2090, 2, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-3 pl-1"">
                                    <div class=""form-group"">
                                        <label>Atmospheric pressure</label>
                                        <input type=""text"" class=""form-control""");
                BeginWriteAttribute("disabled", " disabled=\"", 2458, "\"", 2469, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2470, "\"", 2499, 2);
#nullable restore
#line 40 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 2478, ViewBag.Pressure, 2478, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2495, "hPa", 2496, 4, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-2 pr-1"">
                                    <div class=""form-group"">
                                        <label>Country Name</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 2920, "\"", 2931, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2953, "\"", 2981, 1);
#nullable restore
#line 48 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 2961, ViewBag.CountryName, 2961, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    </div>
                                </div>
                                <div class=""col-md-3 pl-1"">
                                    <div class=""form-group"">
                                        <label>City Name</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 3318, "\"", 3329, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3351, "\"", 3372, 1);
#nullable restore
#line 54 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 3359, ViewBag.Name, 3359, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-2 pl-1"">
                                    <div class=""form-group"">
                                        <label>Longitude</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 3707, "\"", 3718, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3740, "\"", 3758, 1);
#nullable restore
#line 60 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 3748, ViewBag.X, 3748, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-2 pl-1"">
                                    <div class=""form-group"">
                                        <label>Latitude</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 4092, "\"", 4103, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4125, "\"", 4143, 1);
#nullable restore
#line 66 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 4133, ViewBag.Y, 4133, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-3 pl-1"">
                                    <div class=""form-group"">
                                        <label>Timezone (UTC)</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 4483, "\"", 4494, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4516, "\"", 4545, 2);
#nullable restore
#line 72 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 4524, ViewBag.Timezone, 4524, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 4541, "UTC", 4542, 4, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""form-group"">
                                        <label>Weather Description</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 4969, "\"", 4980, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 5002, "\"", 5026, 1);
#nullable restore
#line 80 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 5010, ViewBag.Weather, 5010, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-4 pr-1"">
                                    <div class=""form-group"">
                                        <label>Wind Speed (m/s)</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 5451, "\"", 5462, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 5484, "\"", 5514, 2);
#nullable restore
#line 88 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 5492, ViewBag.WindSpeed, 5492, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 5510, "m/s", 5511, 4, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-4 px-1"">
                                    <div class=""form-group"">
                                        <label>Wind Direction (°)</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 5858, "\"", 5869, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 5891, "\"", 5917, 2);
#nullable restore
#line 94 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 5899, ViewBag.WindDeg, 5899, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 5915, "°", 5916, 2, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-md-4 pl-1"">
                                    <div class=""form-group"">
                                        <label> Cloudiness (%)</label>
                                        <input type=""text""");
                BeginWriteAttribute("disabled", " disabled=\"", 6258, "\"", 6269, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 6291, "\"", 6316, 2);
#nullable restore
#line 100 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
WriteAttributeValue("", 6299, ViewBag.Clound, 6299, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 6314, "%", 6315, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            <div class=""col-md-12"">
                <div class=""card "">
                    <div class=""card-header "">
                        Google Maps
                    </div>
                    <div class=""card-body"">
                        <div id=""mapid""></div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 118 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <div class=\"card\">\r\n                    <h1> Error: City not found</h1>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 126 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<script src=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.js\"\r\n        integrity=\"sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==\"");
            BeginWriteAttribute("crossorigin", "\r\n        crossorigin=\"", 7312, "\"", 7335, 0);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<script>\r\n        var mymap = L.map(\'mapid\').setView([");
#nullable restore
#line 133 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                       Write(ViewBag.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 133 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                                   Write(ViewBag.X);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"], 9);

        L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '&copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors'
        }).addTo(mymap);

        var marker = L.marker([");
#nullable restore
#line 139 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                          Write(ViewBag.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 139 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                      Write(ViewBag.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("]).addTo(mymap);\r\n\r\n    marker.bindPopup(\'<img style=\"background-color:dimgrey\" src=\"");
#nullable restore
#line 141 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                                            Write(ViewBag.LinkIcon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" alt=\"...\" /><br><b>");
#nullable restore
#line 141 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                                                                                  Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br> ");
#nullable restore
#line 141 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                                                                                                        Write(ViewBag.WeatherMin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 141 "D:\RepoVS2019\LoginGoogle\LoginGoogle\Views\Shared\WeatherInfo.cshtml"
                                                                                                                                                Write(ViewBag.Temp);

#line default
#line hidden
#nullable disable
            WriteLiteral(" °C <br>\').openPopup();\r\n</script>\r\n");
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
