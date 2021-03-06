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
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 12 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/_WizardProductSummary.cshtml")]
    public partial class _Views_Checkout__WizardProductSummary_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Checkout__WizardProductSummary_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
  
/*
    Name: Order Summery
    Purpose: Contains Order item Lines, Promotion panel and Order Amount Information
    Structure: /Views/Checkout/_OrderSummary.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Basket/OnePageCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<ul");

WriteLiteral(" id=\"checkout-summery\"");

WriteLiteral(">\r\n    <li");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding itemBorder clearfix\"");

WriteLiteral(" ng-repeat=\"items in ck.basket.lineItems track by $index\"");

WriteLiteral(" ng-if=\'items.parentProductId == ck.emptyGuid\'");

WriteLiteral(">\r\n        <div");

WriteLiteral(" ng-if=\"items.parentProductId == ck.emptyGuid && !items.isSubscription\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-2 col-xs-3 no-padding\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"cart-img\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" ix-src=\"{{items.image}}\"");

WriteLiteral(" class=\"omni-img\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" sizes=\"(min-width: 768px) 540px, 100vw\"");

WriteLiteral(">\r\n                        </a>\r\n                    </span>\r\n                </d" +
"iv>\r\n                <div");

WriteLiteral(" class=\"col-sm-10 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"trash-cart\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"remove\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"ck.addToBasket(items.productId,0,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i></a>\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"basket-item\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" ng-bind=\"items.qty\"");

WriteLiteral("></span>&nbsp;&times;&nbsp;<span");

WriteLiteral(" class=\"disp-inline-b\"");

WriteLiteral(" ng-bind=\"items.price.formatted.withTax\"");

WriteLiteral("></span>\r\n                        <span");

WriteLiteral(" class=\"text-right pull-right label-span-price\"");

WriteLiteral("><strong");

WriteLiteral(" ng-bind=\"items.totalPrice.formatted.withTax\"");

WriteLiteral("></strong></span>\r\n                    </span>\r\n                    ");

WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"row margin-top-sm\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                            <strong");

WriteLiteral(" class=\"text-orange\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 2237), Tuple.Create("\"", 2320)
, Tuple.Create(Tuple.Create("", 2247), Tuple.Create("items.displayInBasket", 2247), true)
, Tuple.Create(Tuple.Create(" ", 2268), Tuple.Create("&&", 2269), true)
, Tuple.Create(Tuple.Create(" ", 2271), Tuple.Create("items.itemType", 2272), true)
, Tuple.Create(Tuple.Create(" ", 2286), Tuple.Create("==", 2287), true)
            
            #line 39 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                           , Tuple.Create(Tuple.Create("", 2289), Tuple.Create<System.Object, System.Int32>(ItemTypes.Bundle.GetHashCode()
            
            #line default
            #line hidden
, 2289), false)
);

WriteLiteral(">");

            
            #line 39 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                                                                                                                                       Write(LT("YourBag.Text.IncludeComponents", "Included Components:"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                            <div");

WriteLiteral(" class=\"row component-row\"");

WriteLiteral(" ng-repeat=\"bundle in ck.basket.lineItems\"");

WriteLiteral(" ng-if=\"bundle.parentProductId == items.productId\"");

WriteLiteral(" ng-show=\"items.displayInBasket\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"col-sm-8 col-xs-8 no-padding\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{bundle.slug}}\"");

WriteLiteral(" ng-bind=\"bundle.name\"");

WriteLiteral("></a>\r\n                                </div>\r\n                                <d" +
"iv");

WriteLiteral(" class=\"col-sm-4 col-xs-4 no-padding text-right\"");

WriteLiteral(">\r\n                                    <strong>");

            
            #line 45 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                                       Write(LT("YourBag.Text.Qty", "Qty:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong><span");

WriteLiteral(" ng-bind=\"bundle.qty\"");

WriteLiteral("></span>\r\n                                </div>\r\n                            </d" +
"iv>\r\n                        </div>\r\n                    </div>\r\n               " +
" </div>\r\n            </div>\r\n\r\n        </div>\r\n       \r\n        \r\n              " +
"      ");

WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"row margin-top-sm\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                            <strong");

WriteLiteral(" class=\"text-orange\"");

WriteAttribute("ng-show", Tuple.Create(" ng-show=\"", 3446), Tuple.Create("\"", 3529)
, Tuple.Create(Tuple.Create("", 3456), Tuple.Create("items.displayInBasket", 3456), true)
, Tuple.Create(Tuple.Create(" ", 3477), Tuple.Create("&&", 3478), true)
, Tuple.Create(Tuple.Create(" ", 3480), Tuple.Create("items.itemType", 3481), true)
, Tuple.Create(Tuple.Create(" ", 3495), Tuple.Create("==", 3496), true)
            
            #line 59 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                           , Tuple.Create(Tuple.Create("", 3498), Tuple.Create<System.Object, System.Int32>(ItemTypes.Bundle.GetHashCode()
            
            #line default
            #line hidden
, 3498), false)
);

WriteLiteral(">");

            
            #line 59 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                                                                                                                                       Write(LT("YourBag.Text.IncludeComponents", "Included Components:"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                            <div");

WriteLiteral(" class=\"row component-row\"");

WriteLiteral(" ng-repeat=\"bundle in ck.basket.lineItems\"");

WriteLiteral(" ng-if=\"bundle.parentProductId == items.productId\"");

WriteLiteral(" ng-show=\"items.displayInBasket\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"col-sm-8 col-xs-8 no-padding\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{bundle.slug}}\"");

WriteLiteral(" ng-bind=\"bundle.name\"");

WriteLiteral("></a>\r\n                                </div>\r\n                                <d" +
"iv");

WriteLiteral(" class=\"col-sm-4 col-xs-4 no-padding text-right\"");

WriteLiteral(">\r\n                                    <strong>");

            
            #line 65 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                                       Write(LT("YourBag.Text.Qty", "Qty:"));

            
            #line default
            #line hidden
WriteLiteral(" </strong><span");

WriteLiteral(" ng-bind=\"bundle.qty\"");

WriteLiteral("></span>\r\n                                </div>\r\n                            </d" +
"iv>\r\n                        </div>\r\n                    </div>\r\n               " +
"\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" ng-if=\"items.parentProductId != ck.emptyGuid\"");

WriteLiteral(" ng-show=\"items.displayInBasket\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-3 col-xs-3 no-padding\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"cart-img\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                            <img");

WriteLiteral(" ix-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" sizes=\"(min-width: 768px) 540px, 100vw\"");

WriteLiteral(">\r\n                        </a>\r\n                    </span>\r\n                </d" +
"iv>\r\n                <div");

WriteLiteral(" class=\"col-sm-9 col-xs-9 no-padding\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"text-right pull-right text-right label-span-price\"");

WriteLiteral("><strong>");

            
            #line 86 "..\..\Views\Checkout\_WizardProductSummary.cshtml"
                                                                                           Write(LT("YourBag.Text.Free", "FREE"));

            
            #line default
            #line hidden
WriteLiteral("</strong></span>\r\n                        <span");

WriteLiteral(" class=\"text-right pull-right text-right label-span-price\"");

WriteLiteral("><strong> &times; </strong></span>\r\n                        <span");

WriteLiteral(" class=\"text-right pull-right text-right label-span-price\"");

WriteLiteral("><strong>{{items.qty}}</strong></span>\r\n                    </span>\r\n            " +
"    </div>\r\n            </div>\r\n        </div>\r\n    </li>\r\n</ul>");

        }
    }
}
#pragma warning restore 1591
