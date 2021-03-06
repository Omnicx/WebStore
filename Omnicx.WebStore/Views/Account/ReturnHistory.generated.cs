﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    
    #line 16 "..\..\Views\Account\ReturnHistory.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 18 "..\..\Views\Account\ReturnHistory.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Account\ReturnHistory.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Account\ReturnHistory.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 20 "..\..\Views\Account\ReturnHistory.cshtml"
    using Omnicx.WebStore.Models.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/ReturnHistory.cshtml")]
    public partial class _Views_Account_ReturnHistory_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<List<Omnicx.WebStore.Models.Commerce.ReturnModel>>
    {
        public _Views_Account_ReturnHistory_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\ReturnHistory.cshtml"
  
/*
    Name: Return History
    Purpose: Show all return request in list view
    Structure: /Views/Account/ReturnHistory.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_Layout.cshtml.cshtml   (For base Structure)
        b-/Views/Account/_MobileSideNav.cshtml  (Navigatiopn For Mobile)

    Contained In (Where we Use this View):
        a-/Views/Shared/_HeaderLayout.cshtml        (Link in Top Header Bar)
        b-/Views/Shared/_MobileHeaderLayout.cshtml  (Link in Mobile Header)
        c-/Views/Account/ReturnRequest.cshtml       (Link for detail view)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..\Views\Account\ReturnHistory.cshtml"
  
    ViewBag.Title = "Return History";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var userRole = SessionContext.CurrentUserRole;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container dataContainer m--top-60\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Account\ReturnHistory.cshtml"
                           Write(LT("MyAccount.Links.Home", "Home"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n                <li>");

            
            #line 34 "..\..\Views\Account\ReturnHistory.cshtml"
               Write(LT("MyAccount.Text.ReturnHistory", "Return History"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    \r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-xs-12 visible-xs\"");

WriteLiteral(" id=\"exTab1\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <h1");

WriteLiteral(" class=\"basket-h1\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Account\ReturnHistory.cshtml"
                                     Write(LT("MyAccount.Links.OrderOnePlace", "Return History"));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n                    <p");

WriteLiteral(" class=\"text-muted basket-text\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Account\ReturnHistory.cshtml"
                                                 Write(LT("MyAccount.Text.FeelFree", "If you have any questions, please feel free to "));

            
            #line default
            #line hidden
WriteLiteral("<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1855), Tuple.Create("\"", 1893)
            
            #line 44 "..\..\Views\Account\ReturnHistory.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(Url.Action("Contact", "pages")
            
            #line default
            #line hidden
, 1862), false)
);

WriteLiteral(">");

            
            #line 44 "..\..\Views\Account\ReturnHistory.cshtml"
                                                                                                                                                                            Write(LT("MyAccount.Text.ContactUs", "Contact Us"));

            
            #line default
            #line hidden
WriteLiteral(",</a> ");

            
            #line 44 "..\..\Views\Account\ReturnHistory.cshtml"
                                                                                                                                                                                                                               Write(LT("MyAccount.Text.Support", " our customer service center is working for you 24/7 ."));

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Account\ReturnHistory.cshtml"
       Write(Html.Partial("~/Views/Account/_MobileSideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4 col-xs-12 hidden-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\Account\ReturnHistory.cshtml"
       Write(Html.Partial("~/Views/Account/_SideNav.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8 col-xs-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"panel-h2\"");

WriteLiteral(">");

            
            #line 56 "..\..\Views\Account\ReturnHistory.cshtml"
                                    Write(LT("MyAccount.Text.Name", "Return History"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"box no-padding col-sm-12 col-xs-12 no-border-bottom\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 no-padding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"table-responsive max-history\"");

WriteLiteral(">\r\n                            <table");

WriteLiteral(" class=\"table table-hover no-border table-striped\"");

WriteLiteral(">\r\n                                <thead>\r\n                                    <" +
"tr>\r\n                                        <th>");

            
            #line 66 "..\..\Views\Account\ReturnHistory.cshtml"
                                       Write(LT("MyAccount.Text.Qty", "Order #"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th>");

            
            #line 67 "..\..\Views\Account\ReturnHistory.cshtml"
                                       Write(LT("MyAccount.Text.GrandTotal", "Status"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th>");

            
            #line 68 "..\..\Views\Account\ReturnHistory.cshtml"
                                       Write(LT("MyAccount.Text.Product", "Order Date"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Account\ReturnHistory.cshtml"
                                                          Write(LT("MyAccount.Text.Price", "Order Value"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n\r\n                                    </tr>\r\n                             " +
"   </thead>\r\n                                <tbody");

WriteLiteral(" id=\"cart\"");

WriteLiteral(">\r\n");

            
            #line 74 "..\..\Views\Account\ReturnHistory.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Account\ReturnHistory.cshtml"
                                     foreach (var item in @Model)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <tr>\r\n                                   " +
"         <td><strong>");

            
            #line 77 "..\..\Views\Account\ReturnHistory.cshtml"
                                                   Write(item.OrderNumber);

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n                                            <td><label");

WriteAttribute("class", Tuple.Create(" class=\"", 3818), Tuple.Create("\"", 3880)
, Tuple.Create(Tuple.Create("", 3826), Tuple.Create("label", 3826), true)
, Tuple.Create(Tuple.Create(" ", 3831), Tuple.Create("label-", 3832), true)
            
            #line 78 "..\..\Views\Account\ReturnHistory.cshtml"
, Tuple.Create(Tuple.Create("", 3838), Tuple.Create<System.Object, System.Int32>(item.StatusLabel
            
            #line default
            #line hidden
, 3838), false)
, Tuple.Create(Tuple.Create(" ", 3855), Tuple.Create("padding-xs", 3856), true)
, Tuple.Create(Tuple.Create(" ", 3866), Tuple.Create("status-inline", 3867), true)
);

WriteLiteral(">");

            
            #line 78 "..\..\Views\Account\ReturnHistory.cshtml"
                                                                                                                 Write(item.StatusLabel);

            
            #line default
            #line hidden
WriteLiteral("</label></td>\r\n                                            <td>");

            
            #line 79 "..\..\Views\Account\ReturnHistory.cshtml"
                                           Write(item.OrderDate);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                            <td");

WriteLiteral(" align=\"right\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Account\ReturnHistory.cshtml"
                                                         Write(item.SubTotal.Formatted.WithTax);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                        </tr>\r\n");

            
            #line 82 "..\..\Views\Account\ReturnHistory.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </tbody>\r\n                            </table>\r\n " +
"                       </div>\r\n\r\n                    </div>\r\n\r\n                <" +
"/div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
