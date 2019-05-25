#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a71e6dd92f54402a862be818e611e5ccaf3418b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ques_UserAnswerLogList), @"mvc.1.0.view", @"/Views/Ques/UserAnswerLogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ques/UserAnswerLogList.cshtml", typeof(AspNetCore.Views_Ques_UserAnswerLogList))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
using lsc.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71e6dd92f54402a862be818e611e5ccaf3418b5", @"/Views/Ques/UserAnswerLogList.cshtml")]
    public class Views_Ques_UserAnswerLogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<lsc.Model.UserAnswerLog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
  
    ViewData["Title"] = "答题";
    Layout = "~/Pages/_Layout.cshtml";
    bool flag = ViewBag.flag;

#line default
#line hidden
            BeginContext(167, 112, true);
            WriteLiteral("\r\n<blockquote class=\"layui-elem-quote\">\r\n    答题记录\r\n    <a class=\"layui-btn layui-btn-normal\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 279, "\"", 320, 1);
#line 12 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
WriteAttributeValue("", 289, flag?"startOk()":"startEr()", 289, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(321, 291, true);
            WriteLiteral(@">开始答题</a>
</blockquote>
<div class=""layui-row"">
    <table class=""layui-table"">
        <thead>
            <tr>
                <th>测试时间</th>
                <th>分数</th>
                <th>耗时</th>
                <th>操作</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
             if (Model != null)
            {
                foreach (UserAnswerLog userAnswerLog in Model)
                {

#line default
#line hidden
            BeginContext(743, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(799, 56, false);
#line 30 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
                        Write(userAnswerLog.CreateTime.ToString("yyyy-MM-dd hh:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(856, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(893, 24, false);
#line 31 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
                        Write(userAnswerLog.TotalScore);

#line default
#line hidden
            EndContext();
            BeginContext(918, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(955, 22, false);
#line 32 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
                        Write(userAnswerLog.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(978, 39, true);
            WriteLiteral("分钟</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1017, "\"", 1073, 2);
            WriteAttributeValue("", 1024, "/Ques/UserAnswerLogInfo?logId=", 1024, 30, true);
#line 33 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
WriteAttributeValue("", 1054, userAnswerLog.Id, 1054, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1074, 45, true);
            WriteLiteral(">查看答题情况</a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 35 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1153, 69, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div id=\"page\"></div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1239, 473, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer, form
        layui.use(['element', 'layer', 'laypage', 'table', 'form'],
            function() {
                form = layui.form;
                layer = layui.layer;
                var laypage = layui.laypage;
                var table = layui.table;

                //分页
                laypage.render({
                    elem: 'page' //分页容器的id
                    ,
                    count: ");
                EndContext();
                BeginContext(1714, 13, false);
#line 56 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
                       Write(ViewBag.total);

#line default
#line hidden
                EndContext();
                BeginContext(1728, 201, true);
                WriteLiteral(" //总页数\r\n                    ,\r\n                    limit: 35,\r\n                    skin: \'#1E9FFF\' //自定义选中色值\r\n                    //,skip: true //开启跳页\r\n                    ,\r\n                    curr: ");
                EndContext();
                BeginContext(1931, 17, false);
#line 62 "D:\gitCode\crm\lsc\lsc.crm\Views\Ques\UserAnswerLogList.cshtml"
                      Write(ViewBag.pageIndex);

#line default
#line hidden
                EndContext();
                BeginContext(1949, 638, true);
                WriteLiteral(@" //获取起始页
                    ,
                    jump: function(obj, first) {
                        console.log(obj)
                        if (!first) {
                            window.location = '/Ques/UserAnswerLogList?pageIndex=' + obj.curr;
                        }
                    },
                    hash: 'fenye' //自定义hash值
                });
            });
        var startEr = function() {
            layer.msg('题库中题数过少暂时不能答题', { icon: 5 });
            return false;
        }
        var startOk = function() {
            windows.location = ""/Ques/StartAnswer"";
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(2590, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<lsc.Model.UserAnswerLog>> Html { get; private set; }
    }
}
#pragma warning restore 1591