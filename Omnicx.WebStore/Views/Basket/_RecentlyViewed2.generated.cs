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
    
    #line 13 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 16 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 18 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Omnicx.WebStore.Models.Commerce;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 15 "..\..\Views\Basket\_RecentlyViewed.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Basket/_RecentlyViewed.cshtml")]
    public partial class _Views_Basket__RecentlyViewed_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<BasketModel>
    {
        public _Views_Basket__RecentlyViewed_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Basket\_RecentlyViewed.cshtml"
  
/*
    Name: Basket
    Purpose: Customer Recently View Products
    Structure: /Views/Basket/_RecentlyViewed.cshtml
    Contains (Partial Views Used):
        a-/Views/Search/_ProductWidget.cshtml    (product Widget to show relative Product Structure)

    Contained In (Where we Use this View):
        a-/Views/Basket/Index.cshtml       (Link in Recently Viewed accordian)
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" ng-if=\"rvp.groupedResult.length > 0\"");

WriteLiteral(">    \r\n    <div");

WriteLiteral(" class=\"row margin-top-sm\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-margin whiteContainer\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"heading-h3\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\Basket\_RecentlyViewed.cshtml"
                              Write(LT("ProductDetail.Label.RecentlyViewed", "Recently Viewed"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding whiteContainer gridView\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"carousel slide\"");

WriteLiteral(" data-ride=\"carousel\"");

WriteLiteral(" data-type=\"multi\"");

WriteLiteral(" data-interval=\"8000\"");

WriteLiteral(" id=\"recentlyViewed\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"carousel-inner\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" ng-repeat=\"productGroup in rvp.groupedResult track by $index\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" ng-repeat=\"product in productGroup track by $index\"");

WriteLiteral(" class=\"item\"");

WriteLiteral(" ng-class=\"{active:$index==0}\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"carousel-col\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 32 "..\..\Views\Basket\_RecentlyViewed.cshtml"
                           Write(Html.Partial("~/Views/Search/_ProductWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n           " +
"         </div>\r\n                </div>\r\n                <a");

WriteLiteral(" class=\"left carousel-control\"");

WriteLiteral(" href=\"#recentlyViewed\"");

WriteLiteral(" data-slide=\"prev\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-chevron-left\"");

WriteLiteral("></i></a>\r\n                <a");

WriteLiteral(" class=\"right carousel-control\"");

WriteLiteral(" href=\"#recentlyViewed\"");

WriteLiteral(" data-slide=\"next\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-chevron-right\"");

WriteLiteral("></i></a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
