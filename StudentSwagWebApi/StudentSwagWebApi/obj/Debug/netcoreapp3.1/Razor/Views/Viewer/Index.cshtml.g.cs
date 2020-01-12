#pragma checksum "C:\Users\BHARGAVI VENI\source\repos\StudentSwagWebApi\StudentSwagWebApi\Views\Viewer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5708be0c7e6f73f5ac5da30df96d053ab42fc1ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Viewer_Index), @"mvc.1.0.view", @"/Views/Viewer/Index.cshtml")]
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
#line 1 "C:\Users\BHARGAVI VENI\source\repos\StudentSwagWebApi\StudentSwagWebApi\Views\_ViewImports.cshtml"
using StudentSwagWebApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BHARGAVI VENI\source\repos\StudentSwagWebApi\StudentSwagWebApi\Views\_ViewImports.cshtml"
using StudentSwagWebApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5708be0c7e6f73f5ac5da30df96d053ab42fc1ba", @"/Views/Viewer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f65b4d5a41d15f99ddf84ceeb0eae58597e57e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Viewer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(" studentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(" studentUpdateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(" studentDeleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5708be0c7e6f73f5ac5da30df96d053ab42fc1ba4653", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title></title>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.js""></script>
    <script type=""text/javascript"">

        // Function triggers when the document is loaded
        $(document).ready(function () {

            // Button Id : #btnGetStudentsData . Click event
            $('#btnGetStudentsData').click(function () {
                $.ajax({
                    url: 'api/Student',
                    type: 'GET',
                    dataType: 'json',
                    success: function (data, textStatus, xhr) {
                         if(data)
		                 {
						    var len = data.length;
						    var txt = """";
						    if(len > 0)
						    {
								    for(var i=0;i<len;i++)
								    {
                        			    if(data[i].name && data[i].gender)
									    {
										    txt += ""<tr><td>""+data[i].id+""</td><td>""+data[i].name+""</td><td>""+data[i].gender+""</td><td>""+ data[i].subject+""</td");
                WriteLiteral(@"></tr>"";
									    }
								    }
						    }						
                            if(txt != """")
					        {
                                $(""#table"").append(txt);
                            }
                         }             
                    }
                    //error: function (xhr, textStatus, errorThrown) {
                    //    alert('Error in Operation');
                    //}
                });
            });

            $('#btnAddStudentsData').click(function () {
            
                
                var name = $('#name').val();  
                var gender = $('#gender').val();
                var subject = $('#subject').val();

               var student = '{ ""name"": ""' + name + '"", ""gender"": ""' + gender + '"", ""subject"": ' + subject + ' } ';
                
                $.ajax({
                    url: 'api/Student',
                    type: 'POST',
                    contentType: ""application/json"",
                    data: ");
                WriteLiteral(@"student,
                    success: function (data, textStatus, xhr) {
                        alert('Student Created !!!');
                    },
                    error: function (xhr, textStatus, errorThrown) {
                         alert(xhr.responseText);
                    }
                    });
            });


            $('#btnUpdateStudentsData').click(function () {
            var name = $('#updatename').val();
            var gender = $('#updategender').val();
            var subject = $('#updatesubject').val();
                var id = $('#updateid').val();

             var student = '{""id"": ' + id + ', ""name"": ""' + name + '"", ""gender"": ""' + gender + '"", ""subject"": ' + subject + ' } ';
            

            $.ajax({
                url: 'api/Student',
                type: 'PUT',
                contentType: ""application/json"",
                data: student,
                success: function (data, textStatus, xhr) {
                    alert('Student ");
                WriteLiteral(@"record updated !!!');
                },
               error: function (xhr, textStatus, errorThrown) {
                         alert(xhr.responseText);
                    }
                });
            });

            $('#btnDeleteStudentsData').click(function () {
                var ID = $('#id').val();
      
                $.ajax({
                    url: 'api/Student',
                    type: 'DELETE',
                    data: ID,
                    success: function (data, textStatus, xhr) {
                        alert('Student record deleted !!!');
                    },
                   error: function (xhr, textStatus, errorThrown) {
                       alert('Error in Operation');
                   }
                });
        });

    });
        
    </script>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5708be0c7e6f73f5ac5da30df96d053ab42fc1ba9677", async() => {
                WriteLiteral("\r\n    <h3>My To-Do List</h3>\r\n\r\n    <button type=\"button\" id=\"btnGetStudentsData\">Get</button>\r\n    <br />\r\n    <br />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5708be0c7e6f73f5ac5da30df96d053ab42fc1ba10071", async() => {
                    WriteLiteral(@"
        <input type=""text"" id=""name"" placeholder=""Name"">

        <input type=""text"" id=""gender"" placeholder=""Gender"">

        <input type=""text"" id=""subject"" placeholder=""Subject"">
        <br /><br />
        <button type=""button"" id=""btnAddStudentsData"">ADD</button>
        <br />
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <br />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5708be0c7e6f73f5ac5da30df96d053ab42fc1ba11791", async() => {
                    WriteLiteral(@"
        <input type=""text"" id=""updateid"" placeholder=""ID.."">

        <input type=""text"" id=""updatename"" placeholder=""Name"">

        <input type=""text"" id=""updategender"" placeholder=""Gender"">

        <input type=""text"" id=""updatesubject"" placeholder=""Subject"">
        <br /><br />
        <button type=""button"" id=""btnUpdateStudentsData"">EDIT</button>
        <br />
    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <br />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5708be0c7e6f73f5ac5da30df96d053ab42fc1ba13603", async() => {
                    WriteLiteral("\r\n        <input type=\"text\" id=\"id\" placeholder=\"ID..\">\r\n        <br /><br />\r\n        <button type=\"button\" id=\"btnDeleteStudentsData\">DELETE</button>\r\n        <br />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <br />


    <table id=""table"" class=""hidden"">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Gender</th>
            <th>Subject</th>
        </tr>
    </table>

    <!--<script src=""Operations.js""></script>-->
");
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
            WriteLiteral("\r\n\r\n</html>");
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
