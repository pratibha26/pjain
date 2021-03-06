#pragma checksum "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca881b6ebc9e6ddf04b13f5e8b422dbf0a209dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CrimeManagementSystem.Pages.Pages_CriminalProfile), @"mvc.1.0.razor-page", @"/Pages/CriminalProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CriminalProfile.cshtml", typeof(CrimeManagementSystem.Pages.Pages_CriminalProfile), null)]
namespace CrimeManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\_ViewImports.cshtml"
using CrimeManagementSystem;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ca881b6ebc9e6ddf04b13f5e8b422dbf0a209dc", @"/Pages/CriminalProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09970178ad3c24ef14fefc1ad07f9783a7a2c1e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CriminalProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
  
    ViewData["title"] = "Criminal's Profile";

#line default
#line hidden
            BeginContext(90, 497, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17f112d8c0fe4d9aa85f36c963a19a51", async() => {
                BeginContext(96, 484, true);
                WriteLiteral(@"
<style>
#crimes {
    font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
    border-collapse: collapse;
    width: 100%;
}

#crimes td, #crimes th {
    border: 1px solid #ddd;
    padding: 8px;
}

#crimes tr:nth-child(even){background-color: #f2f2f2;}

#crimes tr:hover {background-color: #ddd;}

#crimes th {
    padding-top: 12px;
    padding-bottom: 12px;
    text-align: left;
    background-color: rgb(226, 9, 38);
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
            BeginContext(587, 41, true);
            WriteLiteral("\r\n\r\n<h2 class=\"text-center text-success\">");
            EndContext();
            BeginContext(629, 19, false);
#line 33 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                                Write(Model.Criminal.Name);

#line default
#line hidden
            EndContext();
            BeginContext(648, 1162, true);
            WriteLiteral(@"</h2>


<div class=""row"">
    
    <div class=""col-md-6"">
        <h3>List of Crime cases</h3>        
    </div>

    <div class=""panel panel-default"">
        <div class=""panel-body"">
            <table class=""table table-bordered table-striped"" id = ""crimes"">
                <thead>
                    <tr>
                        <th style=""width: 50px;"">Crime ID</th>
                        <th style=""width: 300px;"">Crime Type</th>
                        <th style=""width: 150px;"">Description</th>
                        <th style=""width: 40px;"">Crime Date</th>
                        <th style=""width: 130px;"">Crime Location</th>
                        <th style=""width: 100px;"">Crime Status</th>
                        <th style=""width: 130px;"">Crime Registration Date</th>
                        <th style=""width: 40px;"">Has Evidence</th>
                        <th style=""width: 40px;"">Priority</th>
                        <th style=""width: 100px;"">Assigned Officer</th>
        ");
            WriteLiteral("                <th style=\"width: 100px;\">Victim Name</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 61 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                     foreach(var crime in Model.Criminal.Crimes) {

#line default
#line hidden
            BeginContext(1878, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1941, 8, false);
#line 63 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1949, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1989, 15, false);
#line 64 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.CrimeType);

#line default
#line hidden
            EndContext();
            BeginContext(2004, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2044, 17, false);
#line 65 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2061, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2101, 15, false);
#line 66 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.CrimeDate);

#line default
#line hidden
            EndContext();
            BeginContext(2116, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2156, 19, false);
#line 67 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.CrimeLocation);

#line default
#line hidden
            EndContext();
            BeginContext(2175, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2215, 17, false);
#line 68 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.CrimeStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2232, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2272, 27, false);
#line 69 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.CrimeRegistrationDate);

#line default
#line hidden
            EndContext();
            BeginContext(2299, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 70 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                             if(@crime.HasEvidence)
                            {

#line default
#line hidden
            BeginContext(2390, 46, true);
            WriteLiteral("                                <td>Yes</td>\r\n");
            EndContext();
#line 73 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2532, 45, true);
            WriteLiteral("                                <td>No</td>\r\n");
            EndContext();
#line 77 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                            }

#line default
#line hidden
            BeginContext(2608, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2641, 14, false);
#line 78 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                           Write(crime.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(2655, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2696, "\"", 2760, 2);
            WriteAttributeValue("", 2703, "https://localhost:5001/OfficerProfile?id=", 2703, 41, true);
#line 79 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
WriteAttributeValue("", 2744, crime.OfficerId, 2744, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2761, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2763, 18, false);
#line 79 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                                                                                               Write(crime.Officer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2781, 45, true);
            WriteLiteral("</a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2826, "\"", 2888, 2);
            WriteAttributeValue("", 2833, "https://localhost:5001/VictimProfile?id=", 2833, 40, true);
#line 80 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
WriteAttributeValue("", 2873, crime.VictimId, 2873, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2889, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2891, 17, false);
#line 80 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                                                                                             Write(crime.Victim.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2908, 44, true);
            WriteLiteral("</a></td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\CriminalProfile.cshtml"
                    }

#line default
#line hidden
            BeginContext(2975, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CriminalProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CriminalProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CriminalProfileModel>)PageContext?.ViewData;
        public CriminalProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
