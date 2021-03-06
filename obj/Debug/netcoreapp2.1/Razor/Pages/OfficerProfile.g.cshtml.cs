#pragma checksum "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cdd1f50a6386251bef502cf6550559126e607fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CrimeManagementSystem.Pages.Pages_OfficerProfile), @"mvc.1.0.razor-page", @"/Pages/OfficerProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/OfficerProfile.cshtml", typeof(CrimeManagementSystem.Pages.Pages_OfficerProfile), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cdd1f50a6386251bef502cf6550559126e607fd", @"/Pages/OfficerProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09970178ad3c24ef14fefc1ad07f9783a7a2c1e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OfficerProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
  
    ViewData["title"] = "Officers' Profile";

#line default
#line hidden
            BeginContext(88, 497, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf28ef5a683b447685483ae1cae18129", async() => {
                BeginContext(94, 484, true);
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
    background-color: rgb(34, 5, 141);
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
            BeginContext(585, 41, true);
            WriteLiteral("\r\n\r\n<h2 class=\"text-center text-success\">");
            EndContext();
            BeginContext(627, 18, false);
#line 33 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                                Write(Model.Officer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(645, 44, true);
            WriteLiteral("</h2>\r\n<h3 class=\"text-center text-success\">");
            EndContext();
            BeginContext(690, 25, false);
#line 34 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                                Write(Model.Officer.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(715, 1222, true);
            WriteLiteral(@"</h3>


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
                        <th style=""width: 100px;"">Criminal Name</th>
           ");
            WriteLiteral("             <th style=\"width: 100px;\">Victim Name</th>\r\n                         <th style=\"width: 40px;\">Update</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 63 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                     foreach(var crime in Model.Officer.Crimes) {

#line default
#line hidden
            BeginContext(2004, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2067, 8, false);
#line 65 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2075, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2115, 15, false);
#line 66 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.CrimeType);

#line default
#line hidden
            EndContext();
            BeginContext(2130, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2170, 17, false);
#line 67 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2187, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2227, 15, false);
#line 68 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.CrimeDate);

#line default
#line hidden
            EndContext();
            BeginContext(2242, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2282, 19, false);
#line 69 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.CrimeLocation);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2341, 17, false);
#line 70 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.CrimeStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2358, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2398, 27, false);
#line 71 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.CrimeRegistrationDate);

#line default
#line hidden
            EndContext();
            BeginContext(2425, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 72 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                             if(@crime.HasEvidence)
                            {

#line default
#line hidden
            BeginContext(2516, 46, true);
            WriteLiteral("                                <td>Yes</td>\r\n");
            EndContext();
#line 75 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2658, 45, true);
            WriteLiteral("                                <td>No</td>\r\n");
            EndContext();
#line 79 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                            }

#line default
#line hidden
            BeginContext(2734, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2767, 14, false);
#line 80 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                           Write(crime.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(2781, 41, true);
            WriteLiteral("</td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2822, "\"", 2888, 2);
            WriteAttributeValue("", 2829, "https://localhost:5001/CriminalProfile?id=", 2829, 42, true);
#line 81 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
WriteAttributeValue("", 2871, crime.CriminalId, 2871, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2889, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2891, 19, false);
#line 81 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                                                                                                 Write(crime.Criminal.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2910, 45, true);
            WriteLiteral("</a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2955, "\"", 3017, 2);
            WriteAttributeValue("", 2962, "https://localhost:5001/VictimProfile?id=", 2962, 40, true);
#line 82 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
WriteAttributeValue("", 3002, crime.VictimId, 3002, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3018, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3020, 17, false);
#line 82 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                                                                                             Write(crime.Victim.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3037, 45, true);
            WriteLiteral("</a></td>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3082, "\"", 3145, 2);
            WriteAttributeValue("", 3089, "https://localhost:5001/UpdateCriminalRecord?id=", 3089, 47, true);
#line 83 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
WriteAttributeValue("", 3136, crime.Id, 3136, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3146, 49, true);
            WriteLiteral(">Edit</a></td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 86 "C:\Users\Pratibha Jain\Documents\GitHub\IS7012\CrimeManagementSystem\Pages\OfficerProfile.cshtml"
                    }

#line default
#line hidden
            BeginContext(3218, 82, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfficerProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OfficerProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OfficerProfileModel>)PageContext?.ViewData;
        public OfficerProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
