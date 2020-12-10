#pragma checksum "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b512ef5cb9f9c632fe301db1d4fe5df004d4f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Home_Sells), @"mvc.1.0.view", @"/Areas/Manager/Views/Home/Sells.cshtml")]
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
#line 2 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b512ef5cb9f9c632fe301db1d4fe5df004d4f0b", @"/Areas/Manager/Views/Home/Sells.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c01558d12eac6ac05a704fcfb82ba7e4e3b045", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Home_Sells : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<RestaurantManagementSystem.Areas.Manager.ViewModels.TempSell>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
  
    ViewData["Title"] = "Sells";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
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
        <h1>Ingredient List</h1>
        <table class=""table"">
            <thead>
                <tr>
                    <th>Serial</th>
                    <th>Customer Name</th>
                    <th>FoodName</th>
                    <th>Food Proce</th>
                    <th>Quantity</th>
                    <th>Total</th>
                    <th>Date</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                   var c = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 43 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 45 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 46 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(item.FoodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 47 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 48 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 49 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                       Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 50 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                   Write(item.Date.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                       \n                    </tr>\n");
#nullable restore
#line 53 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
                    c++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n        ");
#nullable restore
#line 58 "F:\IUBAT\Internship\RMS\RestaurantManagementSystem\Areas\Manager\Views\Home\Sells.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, c => Href("~/Manager/Home/Sells?page=" + c),
                new X.PagedList.Mvc.Common.PagedListRenderOptionsBase
                {
                    PageClasses = new string[] { "page-link" },
                    UlElementClasses = new string[] { "pagination" },
                    LiElementClasses = new string[] { "page-item" },

                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"


    <script type=""text/javascript"">

        function MyDeleteConfirm() {
            event.preventDefault();
            var anchor = event.target.closest(""a"");     // Find closest Anchor (or self)
             console.log( anchor.getAttribute('href'));
             Swal.fire({
                  title: 'Are you sure?',
                  text: ""You won't be able to revert this!"",
                  icon: 'warning',
                  showCancelButton: true,
                  confirmButtonColor: '#3085d6',
                  cancelButtonColor: '#d33',
                  confirmButtonText: 'Yes, delete it!',

            }).then((result) => {
                if (result.value) {
                   window.location.href = anchor.getAttribute('href');
                    //Swal.fire(
                    //  'Deleted!',
                    //  'Your file has been deleted.',
                    //  'success'
                    //  )
              }
              })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<RestaurantManagementSystem.Areas.Manager.ViewModels.TempSell>> Html { get; private set; }
    }
}
#pragma warning restore 1591