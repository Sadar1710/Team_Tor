#pragma checksum "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b103b71a2bc2fb3bdcc591439af87e8247f02a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Home_OrderDetails), @"mvc.1.0.view", @"/Areas/Manager/Views/Home/OrderDetails.cshtml")]
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
#line 1 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\_ViewImports.cshtml"
using RestaurantManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\_ViewImports.cshtml"
using RestaurantManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
using RestaurantManagementSystem.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
using RestaurantManagementSystem.Areas.Manager.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b103b71a2bc2fb3bdcc591439af87e8247f02a7e", @"/Areas/Manager/Views/Home/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c01558d12eac6ac05a704fcfb82ba7e4e3b045", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Home_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<RestaurantManagementSystem.Areas.Manager.ViewModels.CustomerOrderVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n\n");
#nullable restore
#line 10 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderedFoodItemList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #cols {
        background-color: ghostwhite;
        border-radius: 8px;
        box-shadow: 0 4px 6px 0 rgba(0,0,0,0.2),0 5px 6px 0 rgba(0,0,0,0.4);
    }

        #cols h1 {
            text-align: center;
            padding: 4%;
        }

    table {
        text-align: center;
    }
</style>
<div class=""row mt-5"">
    <div class=""col-12 col-sm-12 col-md-12 col-lg-10 offset-lg-1 col-xl-10 offset-xl-1"" id=""cols"">
        <h1>Ordered Food Item List</h1>
        <table class=""table table-sm"">
            <thead>
                <tr>
                    <th>Serial</th>
                    <th>Customer Name</th>
                    <th>Mobile</th>
                    <th>Booked From</th>
                    <th>Booked To</th>
                    <th>Table Name</th>
                    <th>Approve Status</th>
                    <th>Seat</th>
                    <th>Payment Status</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 48 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                   var c = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 53 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                       Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 54 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                       Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 55 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                       Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 56 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                       Write(item.BookFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 57 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                       Write(item.BookTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 58 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                       Write(item.TableName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 60 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                             if (item.Approve == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button data-id=\"");
#nullable restore
#line 62 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                            Write(item.CustomerOrderDetailsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-success\" disabled id=\"buttonText\">Approved</button>\n");
#nullable restore
#line 63 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button data-id=\"");
#nullable restore
#line 66 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                            Write(item.CustomerOrderDetailsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger\" id=\"buttonText\">Not Approved</button>\n");
#nullable restore
#line 67 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n");
#nullable restore
#line 71 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                             if (item.TableName != "Special Table")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span id=\"Tb\">---</span>\n");
#nullable restore
#line 74 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                            }
                            else
                            {
                                var a = Context.Session.Get<List<TempTable>>("TempTableSeat");
                                if (a != null)
                                {

                                    var tbl = a.Where(b => b.Id == item.CustomerOrderDetailsId).FirstOrDefault();

                                    if (tbl != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input id=\"Tb\" style=\"width:50px;height:33px\" class=\"form-control\" data-id=\"");
#nullable restore
#line 85 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                                                                                               Write(tbl.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 3012, "\"", 3033, 1);
#nullable restore
#line 85 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
WriteAttributeValue("", 3020, tbl.SeatName, 3020, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly />\n");
#nullable restore
#line 86 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                    }
                                    else
                                    {

                                        if (item.Approve == true && item.PaymentStatus == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <input id=\"Tb\" style=\"width:50px;height:33px\" class=\"form-control\" readonly value=\"---\" />\n");
#nullable restore
#line 93 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"

                                        }
                                        else
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <input id=\"Tb\" style=\"width:50px;height:33px\" class=\"form-control\"  />\n");
#nullable restore
#line 99 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"



                                        }


                                    }
                                }
                                else
                                {
                                    if (item.Approve == true && item.PaymentStatus == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input id=\"Tb\" style=\"width:50px;height:33px\" class=\"form-control\" readonly value=\"---\" />\n");
#nullable restore
#line 112 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"

                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <input id=\"Tb\" style=\"width:50px;height:33px\" class=\"form-control\"  />\n");
#nullable restore
#line 118 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"



                                    }


                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                        <td>\n");
#nullable restore
#line 128 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                             if (item.PaymentStatus == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button data-id=\"");
#nullable restore
#line 130 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                            Write(item.CustomerOrderDetailsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-success\" disabled>Paid</button>\n");
#nullable restore
#line 131 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button data-id=\"");
#nullable restore
#line 135 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                            Write(item.CustomerOrderDetailsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-warning\">Make Payment</button>\n");
#nullable restore
#line 136 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n\n                    </tr>\n");
#nullable restore
#line 140 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
                                        c++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        ");
#nullable restore
#line 144 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\OrderDetails.cshtml"
   Write(Html.PagedListPager((IPagedList) Model, c => Href("~/Manager/Home/OrderDetails?page=" + c),
               new X.PagedList.Mvc.Common.PagedListRenderOptionsBase
               {
                   PageClasses = new string[] { "page-link" },
                   UlElementClasses = new string[] { "pagination" },
                   LiElementClasses = new string[] { "page-item" },

               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {






        });


        $(""button"").click(function () {
            var value = $(this).text();
            var Id = $(this).data(""id"");

            var TableName = $(this).closest(""tr"").find('td:eq(5)').text();
            var Seat = $(this).closest(""tr"").find('td:eq(7)').find(""#Tb"").text();
            var InputValue = $(this).closest(""tr"").find('td:eq(7)').find(""#Tb"").val();
            console.log(InputValue);
            console.log(Seat);
            console.log(value);
            console.log(TableName);
            var ButtonValue = $(this).closest(""tr"").find('td:eq(6)').find(""#buttonText"").text();
            console.log(""Button Value :"" + ButtonValue);
            if (Seat === ""---"") {

                if (value === ""Not Approved"") {
                    $(this).removeClass(""btn btn-danger"").addClass(""btn btn-success"");
                    $(this).off('click');
                    var value = $(this).text(""Approved"");
");
                WriteLiteral(@"                    var url = ""/Manager/Home/OrderApproved"";
                    console.log(Id);
                    $.getJSON(url, { id: Id }, function (data) {
                        console.log(data);
                    });
                }
                


            }
            else if (InputValue.length !== 0) {
                if (value === ""Not Approved"") {
                    $(this).removeClass(""btn btn-danger"").addClass(""btn btn-success"");
                    $(this).off('click');
                    $(this).text(""Approved"");
                    $(this).closest(""tr"").find('td:eq(7)').find(""#Tb"").attr(""readonly"", ""true"");
                    var TableName = $(this).closest(""tr"").find('td:eq(7)').find(""#Tb"").val();

                    var url = ""/Manager/Home/OrderApprovedWithoutTable"";
                    console.log(""Passed Id "" + Id);
                    console.log(""Passed Seat "" + TableName);
                    $.getJSON(url, { id: Id, Seat: TableName }, function (data) {
            ");
                WriteLiteral(@"            console.log(data);
                    });
                }
                
                
                   
            }
            if (value === ""Make Payment"" && InputValue.length !== 0
                && ButtonValue === ""Approved"")
            {
               var OrderId = $(this).closest(""tr"").find('button').data(""id"");
                console.log(""Order ID "" + OrderId);
                $(this).text(""Paid"");
                $(this).removeClass(""btn btn-warning"").addClass(""btn btn-success"");
                $(this).off('click');

                window.location.href = '/Manager/Home/Receipt?id=' + OrderId;
            }
            else if (Seat === ""---"" 
                        && ButtonValue===""Approved"")
            {
                $(this).text(""Paid"");
                $(this).removeClass(""btn btn-warning"").addClass(""btn btn-success"");
                $(this).off('click');
                 var OrderId = $(this).closest(""tr"").find('button').data(""id"");
                console.log");
                WriteLiteral(@"(""Order ID "" + OrderId);
                window.location.href = '/Manager/Home/Receipt?id=' + OrderId;
            }
            //else {

            //    var url = ""/Manager/Home/OrderApproved"";
            //        console.log(Id);
            //        $.getJSON(url, { id: Id }, function (data) {
            //            console.log(data);
            //        });
            //}
            //console.log(value);
            //console.log(TableName);



        });



    </script>
");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<RestaurantManagementSystem.Areas.Manager.ViewModels.CustomerOrderVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
