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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Checkout/Layout1/_CheckoutOrderReview.cshtml")]
    public partial class _Views_Checkout_Layout1__CheckoutOrderReview_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Checkout_Layout1__CheckoutOrderReview_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
  
/*
    Name: Standard Checkout Order Overview
    Purpose: Show All the information in single view before proceed to payment
    Structure: /Views/Checkout/Layout1/_CheckoutOrderReview.cshtml
    Contains (Partial Views Used):

    Contained In (Where we Use this View):
        a-/Views/Basket/Layout1/StandardCheckout.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-show=\"ck.orderDetail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(" id=\"checkout\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"alertDynamicBlock\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" id=\"divErrMsg\"");

WriteLiteral(" class=\"alert alert-danger hide\"");

WriteLiteral(">\r\n                    <div>\r\n                        <i");

WriteLiteral(" class=\"icon-warning\"");

WriteLiteral("></i><span></span>\r\n                    </div>\r\n                </div>\r\n         " +
"   </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"checkout-h2\"");

WriteLiteral(">Review your order</h2>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding visible-xs\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12 no-padding pull-right margin-bottom-lg\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
               
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                if (SessionContext.CurrentUser != null)
               {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"btn btn-checkout width-full \"");

WriteLiteral(" ng-click=\"ck.paymentMethod()\"");

WriteLiteral(">Place Your Order and Pay <i");

WriteLiteral(" class=\"fa fa-lock\"");

WriteLiteral("></i></a>\r\n");

            
            #line 32 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
               }
               else
               {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" class=\"btn btn-checkout width-full \"");

WriteLiteral(" ng-click=\"ck.setPassword()\"");

WriteLiteral(">Place Your Order and Pay <i");

WriteLiteral(" class=\"fa fa-lock\"");

WriteLiteral("></i></a>\r\n");

            
            #line 36 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
               }

            
            #line default
            #line hidden
WriteLiteral("                <p");

WriteLiteral(" class=\"checkout-secure-text\"");

WriteLiteral(">You\'ll be securely redirected to payment gateway for complete your purchase.</p>" +
"\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12 pull-right no-padding-right-d\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"checkout-h3\"");

WriteLiteral(">Order Summery</h2>\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkoutStepSummery\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 hidden-xs margin-top-sm\"");

WriteLiteral(">\r\n");

            
            #line 44 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                     if (SessionContext.CurrentUser != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteLiteral(" class=\"btn btn-checkout width-full \"");

WriteLiteral(" ng-click=\"ck.paymentMethod()\"");

WriteLiteral(">Place Your Order and Pay <i");

WriteLiteral(" class=\"fa fa-lock\"");

WriteLiteral("></i></a>\r\n");

            
            #line 47 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteLiteral(" class=\"btn btn-checkout width-full \"");

WriteLiteral(" ng-click=\"ck.setPassword()\"");

WriteLiteral(">Place Your Order and Pay <i");

WriteLiteral(" class=\"fa fa-lock\"");

WriteLiteral("></i></a>\r\n");

            
            #line 51 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <p");

WriteLiteral(" class=\"checkout-secure-text\"");

WriteLiteral(">You\'ll be securely redirected to payment gateway for complete your purchase.</p>" +
"\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(" ng-show=\"ck.hideBillingAddress\"");

WriteLiteral(">\r\n                    <h6");

WriteLiteral(" class=\"checkout-summery-h6\"");

WriteLiteral(">\r\n                        Shipping to:\r\n                        <strong>\r\n      " +
"                      <b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.firstName\"");

WriteLiteral("></b> <b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.lastName\"");

WriteLiteral("></b>,<b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.address1\"");

WriteLiteral("></b>,<b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.address2\"");

WriteLiteral("></b>, <b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.city\"");

WriteLiteral("></b>,<b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.state\"");

WriteLiteral("></b>,<b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.country\"");

WriteLiteral("></b>,<b");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.postCode\"");

WriteLiteral("></b>\r\n                        </strong>\r\n                    </h6>\r\n            " +
"    </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <table");

WriteLiteral(" class=\"table no-margin-top no-border\"");

WriteLiteral(">\r\n                        <tbody>\r\n                            <tr>\r\n           " +
"                     <td>");

            
            #line 66 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                               Write(LT("Checkout.Label.Subtotal", "Items"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" ng-bind=\"ck.basket.subTotal.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                            </tr>\r\n                            <tr>\r\n    " +
"                            <td>");

            
            #line 70 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                               Write(LT("Checkout.Label.ShippingCharge", "Shipping and handling"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" ng-bind=\"ck.basket.shippingCharge.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                            </tr>\r\n                            <tr>\r\n    " +
"                            <td>");

            
            #line 74 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                               Write(LT("Checkout.Label.Tax", "Tax"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" ng-bind=\"ck.basket.subTotal.formatted.tax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                            </tr>\r\n                            <tr>\r\n    " +
"                            <td>");

            
            #line 78 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                               Write(LT("Checkout.Label.Discount", "Discount"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <th");

WriteLiteral(" ng-bind=\"ck.basket.discount.formatted.withTax\"");

WriteLiteral(" class=\"text-right\"");

WriteLiteral("></th>\r\n                            </tr>\r\n                            <tr");

WriteLiteral(" ng-show=\"ck.basket.promotionsApplied.length>0\"");

WriteLiteral(" id=\"PromoApplied3\"");

WriteLiteral(">\r\n                                <td>Promotions Applied:</td>\r\n                " +
"                <th");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">\r\n                                    <ul");

WriteLiteral(" class=\"promo-ul\"");

WriteLiteral(">\r\n                                        <li");

WriteLiteral(" class=\"no-padding\"");

WriteLiteral(" ng-repeat=\"promotion in ck.basket.promotionsApplied\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"ck.removePromoCode(ck.basket.id,promotion.promoCode)\"");

WriteLiteral("><label");

WriteLiteral(" ng-bind=\"promotion.name\"");

WriteLiteral("></label> <i");

WriteLiteral(" class=\"fa fa-remove\"");

WriteLiteral("></i></a>\r\n                                        </li>\r\n                       " +
"             </ul>\r\n                                </th>\r\n                     " +
"       </tr>\r\n                            <tr");

WriteLiteral(" class=\"total\"");

WriteLiteral(">\r\n                                <td><strong");

WriteLiteral(" class=\"checkout-total\"");

WriteLiteral(">");

            
            #line 92 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                              Write(LT("Checkout.Label.OrderTotal", "Order Total"));

            
            #line default
            #line hidden
WriteLiteral("</strong></td>\r\n                                <th");

WriteLiteral(" ng-bind=\"ck.basket.grandTotal.formatted.withTax\"");

WriteLiteral(" class=\"text-right checkout-total-amount\"");

WriteLiteral("></th>\r\n                            </tr>\r\n                        </tbody>\r\n    " +
"                </table>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"summery-box\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral(">\r\n                            <h4><i");

WriteLiteral(" class=\"fa fa-ticket\"");

WriteLiteral("></i> ");

            
            #line 101 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                        Write(LT("Checkout.Label.PromotionCode" , "Coupon code"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                        </div>\r\n                        <p");

WriteLiteral(" class=\"text-muted padding-sm label-span-desc\"");

WriteLiteral(">");

            
            #line 103 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                                    Write(LT("Checkout.Text.HaveCoupon" , "If you have a coupon code, please enter it in the box below"));

            
            #line default
            #line hidden
WriteLiteral(".</p>\r\n                        <form");

WriteLiteral(" ng-submit=\"ck.applyPromoCode(ck.basket.id,promoCode)\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"input-group padding-sm\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"promoCode\"");

WriteLiteral(" placeholder=\"Enter Coupon Code\"");

WriteLiteral(" />\r\n                                <span");

WriteLiteral(" class=\"input-group-btn\"");

WriteLiteral(">\r\n                                    <button");

WriteLiteral(" class=\"btn btn-checkout\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-gift\"");

WriteLiteral("></i></button>\r\n                                </span>\r\n                        " +
"    </div>\r\n                            <!-- /input-group -->\r\n                 " +
"       </form>\r\n                        <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger promo\"");

WriteLiteral(" ng-show=\"ck.invalidpromo\"");

WriteLiteral(">\r\n                            <span>");

            
            #line 114 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                             Write(LT("Checkout.Text.InValidPromoMessage" , "PromoCode Invalid!"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                        <div ng-cloak");

WriteLiteral(" class=\"alert alert-success promovalid\"");

WriteLiteral(" ng-show=\"ck.validpromo\"");

WriteLiteral(">\r\n                            <span>");

            
            #line 117 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                             Write(LT("Checkout.Text.ValidPromoMessage" , "Successfully Applied"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                        <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger promonull\"");

WriteLiteral(" ng-show=\"ck.promonull\"");

WriteLiteral(">\r\n                            <span>");

            
            #line 120 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                             Write(LT("Checkout.Text.NullPromoMessage" , "Please enter promo code!"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n            " +
"    </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"summery-box\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral(">\r\n                            <h4><i");

WriteLiteral(" class=\"fa fa-gift\"");

WriteLiteral("></i> ");

            
            #line 127 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                      Write(LT("Checkout.Label.GiftForMe", "Who are you purchasing for today?"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"control control--checkbox\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral("  ng-change=\"ck.purchaseFor(purchase)\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-model=\"purchase.me\"");

WriteLiteral(" >\r\n                                <label");

WriteLiteral(" for=\"NewsLetterSubscribe\"");

WriteLiteral(">");

            
            #line 133 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                            Write(LT("Checkout.Label.PurchasingForMe", "This order is just for me."));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                            </label>\r\n                        </div>\r\n\r\n" +
"                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" class=\"control control--checkbox \"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-change=\"ck.purchaseFor(purchase)\"");

WriteLiteral(" class=\"ng-pristine ng-valid\"");

WriteLiteral(" ng-model=\"purchase.gift\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" for=\"NewsLetterSubscribe\"");

WriteLiteral(">");

            
            #line 141 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                            Write(LT("Checkout.Label.PurchasingForGift", "This order contains a gift."));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <div");

WriteLiteral(" class=\"control__indicator\"");

WriteLiteral("></div>\r\n                            </label>\r\n                        </div>\r\n\r\n" +
"                    </div>\r\n                </div>\r\n            </div>\r\n        " +
"</div>\r\n        <div");

WriteLiteral(" class=\"col-sm-8 col-xs-12 pull-left no-padding\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" class=\"checkout-h3\"");

WriteLiteral(">Shipping information</h2>\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkoutStepSummery\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding border-bottom-blog\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"checkout-summery-edit\"");

WriteLiteral(" ng-click=\"ck.orderDetail=false;ck.showDeliveryOption=true;ck.isComplete=1;\"");

WriteLiteral("></a>\r\n                    <div");

WriteLiteral(" class=\"col-sm-3 col-xs-12\"");

WriteLiteral("><h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral("><strong>Shipping method<span></span></strong></h6></div>\r\n                    <d" +
"iv");

WriteLiteral(" class=\"col-sm-9 col-xs-12\"");

WriteLiteral("><h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral(" ng-bind=\"ck.model.checkout.selectedShipping.displayName\"");

WriteLiteral("></h6></div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(" ng-show=\"ck.hideBillingAddress\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"checkout-summery-edit\"");

WriteLiteral(" ng-click=\"ck.orderDetail=false;ck.deliverAddress=true;ck.isComplete=1;\"");

WriteLiteral("></a>\r\n                    <div");

WriteLiteral(" class=\"col-sm-3 col-xs-12\"");

WriteLiteral("><h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral("><strong>Shipping address</strong></h6></div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-9 col-xs-12\"");

WriteLiteral(">\r\n                        <h6");

WriteLiteral(" class=\"checkout-summery-h6\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.firstName\"");

WriteLiteral("></span> <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.lastName\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.address1\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.address2\"");

WriteLiteral("></span>, <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.city\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.state\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.country\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.shippingAddress.postCode\"");

WriteLiteral("></span>\r\n                        </h6>\r\n                    </div>\r\n            " +
"    </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"or-spacer\"");

WriteLiteral("><div");

WriteLiteral(" class=\"mask\"");

WriteLiteral("></div></div>\r\n            <h2");

WriteLiteral(" class=\"checkout-h3\"");

WriteLiteral(">Payment information</h2>\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkoutStepSummery\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding border-bottom-blog\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"checkout-summery-edit\"");

WriteLiteral(" ng-click=\"ck.orderDetail=false;ck.showPaymentOption=true;ck.isComplete=1;\"");

WriteLiteral("></a>\r\n                    <div");

WriteLiteral(" class=\"col-sm-3 col-xs-12\"");

WriteLiteral("><h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral("><strong>Payment method</strong></h6></div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-9 col-xs-12\"");

WriteLiteral("><h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral(" ng-bind=\"ck.model.checkout.selectedPayment.displayName\"");

WriteLiteral("></h6></div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"checkout-summery-edit\"");

WriteLiteral(" ng-click=\"ck.orderDetail=false;ck.showPaymentOption=true;ck.isComplete=1;\"");

WriteLiteral("></a>\r\n                    <div");

WriteLiteral(" class=\"col-sm-3 col-xs-12\"");

WriteLiteral("><h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral("><strong>Billing address</strong></h6></div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-9 col-xs-12\"");

WriteLiteral(">\r\n                        <h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral(" ng-show=\"ck.sameAsBillAddress\"");

WriteLiteral(">Same as delivery address</h6>\r\n                        <h6");

WriteLiteral(" class=\"checkout-summery-h6 no-margin\"");

WriteLiteral(" ng-hide=\"ck.sameAsBillAddress\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.firstName\"");

WriteLiteral("></span> <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.lastName\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.address1\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.address2\"");

WriteLiteral("></span>, <span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.city\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.state\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.country\"");

WriteLiteral("></span>,<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.billingAddress.postCode\"");

WriteLiteral("></span>\r\n                        </h6>\r\n                    </div>\r\n            " +
"    </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"or-spacer\"");

WriteLiteral("><div");

WriteLiteral(" class=\"mask\"");

WriteLiteral("></div></div>\r\n            <h2");

WriteLiteral(" class=\"checkout-h3\"");

WriteLiteral(">Order Shipment</h2>\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkoutStepSummery\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" id=\"checkout-summery\"");

WriteLiteral(">\r\n                        <li>\r\n                            <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv\"");

WriteLiteral(" ng-show=\"ck.wishlisterror\"");

WriteLiteral(">\r\n                                User <strong>");

            
            #line 194 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                        Write(LT("ProductDetail.Message.LoginRequired", "Login Required"));

            
            #line default
            #line hidden
WriteLiteral("!</strong>\r\n                            </div>\r\n                        </li>\r\n  " +
"                      <li");

WriteLiteral(" class=\"single-cart-item clearfix\"");

WriteLiteral(" ng-repeat=\"items in ck.basket.lineItems\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"cart-img\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(">\r\n                                </a>\r\n                            </span>\r\n   " +
"                         <span");

WriteLiteral(" class=\"trash-cart\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"remove\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"ck.addToBasket(items.productId,0,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i></a>\r\n                            </span>\r\n                            <span" +
"");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                <button");

WriteLiteral(" class=\"btn-cart\"");

WriteLiteral(" ng-click=\"ck.addToBasket(items.productId,-1,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-minus\"");

WriteLiteral("></i></button>\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" value=\"{{items.qty}}\"");

WriteLiteral(" class=\"cart-text form-control\"");

WriteLiteral(" numbers-Only>\r\n                                <button");

WriteLiteral(" class=\"btn-cart\"");

WriteLiteral(" ng-click=\"ck.addToBasket(items.productId,1,items.displayOrder)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-plus\"");

WriteLiteral("></i></button>\r\n                                <span");

WriteLiteral(" class=\"text-right pull-right label-span-price\"");

WriteLiteral("><strong");

WriteLiteral(" ng-bind=\"items.price.formatted.withTax\"");

WriteLiteral("></strong></span><br/>\r\n");

            
            #line 214 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 214 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                 if (SessionContext.CurrentUser != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"ck.addProductToWishlist(items);\"");

WriteLiteral(">Save for later</a>\r\n");

            
            #line 217 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"ck.validateWishlist();\"");

WriteLiteral(">Save for later</a>\r\n");

            
            #line 221 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </span>\r\n                        </li>\r\n             " +
"       </ul>\r\n                </div>\r\n            </div>\r\n");

            
            #line 227 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
            
            
            #line default
            #line hidden
            
            #line 227 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
             if (SessionContext.CurrentUser != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"box-header\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"checkout-h3\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-basket\"");

WriteLiteral("></i> ");

            
            #line 230 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
                                                                             Write(LT("Checkout.Label.OrderSummary", "Saved for later"));

            
            #line default
            #line hidden
WriteLiteral(" (<span");

WriteLiteral(" ng-bind=\"ck.model.checkout.wishlistProducts.length\"");

WriteLiteral("></span>)</h3>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 checkoutStepSummery\"");

WriteLiteral(">                    \r\n                    <ul");

WriteLiteral(" id=\"checkout-summery\"");

WriteLiteral(">\r\n                        <li");

WriteLiteral(" class=\"single-cart-item clearfix\"");

WriteLiteral(" ng-repeat=\"items in ck.model.checkout.wishlistProducts\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"cart-img\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" ng-src=\"{{items.image}}\"");

WriteLiteral(" onerror=\"this.src = \'/assets/theme/ocx/images/noimagefound.jpg\'\"");

WriteLiteral(">\r\n                                </a>\r\n                            </span>\r\n   " +
"                         <span");

WriteLiteral(" class=\"trash-cart\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"remove\"");

WriteLiteral(" title=\"Remove\"");

WriteLiteral(" ng-click=\"ck.removeProductToWishlist(items)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash-o\"");

WriteLiteral("></i></a>\r\n                            </span>\r\n                            <span" +
"");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" class=\"small-cart-name\"");

WriteLiteral(" ng-href=\"/{{items.slug}}\"");

WriteLiteral(" ng-bind=\"items.name\"");

WriteLiteral("></a>\r\n                            </span>\r\n                            <span");

WriteLiteral(" class=\"cart-info\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"text-right pull-right label-span-price\"");

WriteLiteral("><strong");

WriteLiteral(" ng-bind=\"items.price.formatted.withTax\"");

WriteLiteral("></strong></span>\r\n                                <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" ng-click=\"ck.removeProductToWishlist(items);ck.addToBasket(items.recordId,1,0);\"" +
"");

WriteLiteral(">Add to Cart</a>\r\n                            </span>\r\n                        </" +
"li>\r\n                    </ul>\r\n                </div>\r\n");

            
            #line 253 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 visible-xs\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-4 col-xs-12 no-padding pull-right margin-bottom-lg\"");

WriteLiteral(">\r\n");

            
            #line 259 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
           
            
            #line default
            #line hidden
            
            #line 259 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
            if (SessionContext.CurrentUser != null)
           {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"btn btn-checkout width-full \"");

WriteLiteral(" ng-click=\"ck.paymentMethod()\"");

WriteLiteral(">Place Your Order and Pay <i");

WriteLiteral(" class=\"fa fa-lock\"");

WriteLiteral("></i></a>\r\n");

            
            #line 262 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
           }
           else
           {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"btn btn-checkout width-full \"");

WriteLiteral(" ng-click=\"ck.setPassword()\"");

WriteLiteral(">Place Your Order and Pay <i");

WriteLiteral(" class=\"fa fa-lock\"");

WriteLiteral("></i></a>\r\n");

            
            #line 266 "..\..\Views\Checkout\Layout1\_CheckoutOrderReview.cshtml"
           }

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"checkout-secure-text\"");

WriteLiteral(">You\'ll be securely redirected to payment gateway for complete your purchase.</p>" +
"\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591