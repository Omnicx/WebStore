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
    
    #line 14 "..\..\Views\Product\_QuickViewModal.cshtml"
    using Omnicx.WebStore.Models.Catalog;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/_QuickViewModal.cshtml")]
    public partial class _Views_Product__QuickViewModal_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Catalog.ProductDetailModel>
    {
        public _Views_Product__QuickViewModal_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Product\_QuickViewModal.cshtml"
  
/*
    Name: Quick View Product popup modal
    Purpose: Show brief description of product in popup modal
    Structure: /Views/Product/_QuickViewModal.cshtml
    Contains (Partial Views Used):
        a-/Views/Product/_QuickViewBundle.cshtml

    Contained In (Where we Use this View):
        a-/Views/Product/ProductDetail.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"product-quick-view-modal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"false\"");

WriteLiteral(" ng-show=\"productmodal\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog modal-lg\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">            \r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"row quick-view product-main\"");

WriteLiteral(" ng-hide=\"pm.model.componentProducts.length > 0\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-5 col-xs-12\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-3 col-xs-4 hidden-xs\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" ng-repeat=\"img in pm.model.images track by $index\"");

WriteLiteral(" ng-if=\"$index!=1\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"item\"");

WriteLiteral(" ng-class=\"{active : $index==0}\"");

WriteLiteral(" ng-if=\"img.url!=\'\'\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"col-xs-12 col-sm-12 thumbs\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" class=\"thumb\"");

WriteLiteral(">\r\n                                                <img");

WriteLiteral(" ng-src=\"{{img.url}}\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(" ng-click=\"pm.model.image=img.url\"");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" />\r\n                                            </a>\r\n                          " +
"              </div>\r\n                                    </div>\r\n              " +
"                  </div>\r\n                            </div>\r\n                  " +
"          <div");

WriteLiteral(" class=\"col-sm-9 col-xs-12\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"quick-view-main-image\"");

WriteLiteral(">\r\n                                    <img");

WriteLiteral(" ng-src=\"{{pm.model.image}}\"");

WriteLiteral(" class=\"img-responsive\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n  " +
"                      </div>\r\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"animate btn-success btn-xl pull-left width-80\"");

WriteLiteral(" ng-disabled=\"pm.addToBag\"");

WriteLiteral(" ng-if=\"pm.model.isDiscontinued==false && pm.model.currentStock>0\"");

WriteLiteral(" ng-click=\"gm.addToBasket(pm.model.recordId,1,0)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-cart\"");

WriteLiteral("></i>");

            
            #line 44 "..\..\Views\Product\_QuickViewModal.cshtml"
                                                                                                                                                                                                                                                                                       Write(LT("Checkout.Button.AddtoBag", "Add to Cart"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 45 "..\..\Views\Product\_QuickViewModal.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Product\_QuickViewModal.cshtml"
                                 if (SessionContext.CurrentUser != null && this.Request.IsAuthenticated)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-danger btn-md pull-right width-20 hidden-xs hidden-sm\"");

WriteLiteral(" ng-click=\"pm.addToWishlist(pm.model.recordId)\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3108), Tuple.Create("\"", 3175)
            
            #line 47 "..\..\Views\Product\_QuickViewModal.cshtml"
                                                                                                          , Tuple.Create(Tuple.Create("", 3116), Tuple.Create<System.Object, System.Int32>(LT("ProductDetail.Links.Addtowishlist", "Add to wishlist")
            
            #line default
            #line hidden
, 3116), false)
);

WriteLiteral(" data-toggle=\"tooltip\"");

WriteLiteral(" data-placement=\"top\"");

WriteLiteral(" ng-hide=\"pm.model.inWishList\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i></button>\r\n");

WriteLiteral("                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"animate btn-danger btn-md pull-right width-20 visible-xs visible-sm\"");

WriteLiteral(" ng-click=\"pm.addToWishlist(pm.model.recordId)\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i></button>\r\n");

            
            #line 49 "..\..\Views\Product\_QuickViewModal.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"animate btn-danger btn-md pull-right width-20\"");

WriteLiteral(" data-toggle=\"modal\"");

WriteLiteral(" data-target=\"#login-modal\"");

WriteLiteral(" data-placement=\"top\"");

WriteLiteral(" ng-click=\"pm.addToWishlist(pm.model.recordId);pm.hideQickView()\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3859), Tuple.Create("\"", 3926)
            
            #line 52 "..\..\Views\Product\_QuickViewModal.cshtml"
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 3867), Tuple.Create<System.Object, System.Int32>(LT("ProductDetail.Links.Addtowishlist", "Add to wishlist")
            
            #line default
            #line hidden
, 3867), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral(" data-toggle=\"tooltip\"");

WriteLiteral(" title=\"Add to wishlist\"");

WriteLiteral(" data-placement=\"top\"");

WriteLiteral("></i></button>\r\n");

            
            #line 53 "..\..\Views\Product\_QuickViewModal.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div>\r\n                        </div>\r\n             " +
"       </div>\r\n                    <div");

WriteLiteral(" class=\"col-sm-7 col-xs-12 borderLeft maxHeightDetail\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                                <h2");

WriteLiteral(" class=\"productName\"");

WriteLiteral(" ng-bind=\"pm.model.name\"");

WriteLiteral("></h2>\r\n                                <h2");

WriteLiteral(" class=\"productBrand\"");

WriteLiteral(" ng-bind=\"pm.model.brand\"");

WriteLiteral("></h2>\r\n                                <h3>\r\n                                   " +
" <span");

WriteLiteral(" ng-repeat=\"freeProduct in pm.model.freeProducts\"");

WriteLiteral(" class=\"text-bold\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"pluse-icon sprite\"");

WriteLiteral(">+</i> ");

            
            #line 64 "..\..\Views\Product\_QuickViewModal.cshtml"
                                                                      Write(LT("ProductDetail.Label.Free", "Free"));

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" ng-bind=\"freeProduct.name\"");

WriteLiteral("></span>\r\n                                    </span>\r\n                          " +
"      </h3>\r\n                            </div>\r\n                        </div>\r" +
"\n                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"price\"");

WriteLiteral(" ng-bind=\"pm.model.price.formatted.withTax\"");

WriteLiteral("></span>\r\n                                <span");

WriteLiteral(" class=\"product-price-save\"");

WriteLiteral("><span");

WriteLiteral(" ng-bind=\"pm.model.listPrice.formatted.withTax\"");

WriteLiteral("></span></span>\r\n                            </div>\r\n                        </di" +
"v>\r\n                        <div");

WriteLiteral(" class=\"row margin-top-sm\"");

WriteLiteral(" ng-if=\"pm.model.variantProductsAttribute[0].displayInProductWidget\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 margin-bottom-sm\"");

WriteLiteral(" ng-repeat=\"attr in pm.model.variantProductsAttribute\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"col-sm-2 col-xs-12 no-padding-left\"");

WriteLiteral(">\r\n                                        <h4");

WriteLiteral(" class=\"detailHeading\"");

WriteLiteral(" ng-bind=\"attr.fieldName\"");

WriteLiteral("></h4>\r\n                                    </div>\r\n                             " +
"       <div");

WriteLiteral(" class=\"col-sm-10 col-xs-12 no-padding\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" ng-show=\"attr.selectedValue==\'\'\"");

WriteLiteral(" class=\"color-error-validation\"");

WriteLiteral(">Please Select {{attr.fieldName}} </span>\r\n                                      " +
"  <div");

WriteLiteral(" ng-if=\"attr.inputType != \'Dropdown\'\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" ng-repeat=\"item in attr.fieldValues\"");

WriteLiteral(">\r\n                                                <a");

WriteLiteral(" ng-if=\"attr.fieldCode==\'global.colour\'\"");

WriteLiteral(" id=\"{{item.fieldValue}}\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" ng-click=\"pm.getAvailableAttributeValues(attr.fieldCode,item.fieldValue,item.sel" +
"ected,attr.independentProductUrl)\"");

WriteLiteral("\r\n                                                   class=\"varient-box btn\"");

WriteLiteral(" ng-class=\"item.available==true?\'\':\' grayOut-Color\'\"");

WriteLiteral(" style=\"background-color: {{item.fieldValue}}\"");

WriteLiteral(">\r\n                                                    <i");

WriteLiteral(" ng-if=\"item.selected && item.available\"");

WriteLiteral(" class=\"fa-1x fa fa-check varient-check\"");

WriteLiteral("></i>\r\n                                                </a>\r\n                    " +
"                            <a");

WriteLiteral(" ng-if=\"attr.fieldCode!=\'global.colour\'\"");

WriteLiteral(" id=\"{{item.fieldValue}}\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" ng-click=\"pm.getAvailableAttributeValues(attr.fieldCode,item.fieldValue,item.sel" +
"ected,attr.independentProductUrl)\"");

WriteLiteral("\r\n                                                   class=\"varient-box-large \"");

WriteLiteral(" ng-class=\"item.available==true?\'\':\' grayOut\'\"");

WriteLiteral(">\r\n                                                    {{item.fieldValue}}\r\n     " +
"                                               <i");

WriteLiteral(" ng-if=\"item.selected && item.available\"");

WriteLiteral(" class=\"fa-1x fa fa-check varient-check-range\"");

WriteLiteral("></i>\r\n                                                </a>\r\n                    " +
"                        </div>\r\n                                        </div>\r\n" +
"                                        <div");

WriteLiteral(" ng-if=\"attr.inputType == \'Dropdown\'\"");

WriteLiteral(">\r\n                                            <select");

WriteLiteral(" ng-model=\"attr.selectedValue\"");

WriteLiteral(" ng-change=\"pm.getAvailableAttributeValues(attr.fieldCode,attr.selectedValue,fals" +
"e,attr.independentProductUrl)\"");

WriteLiteral(" class=\"varientDdb\"");

WriteLiteral(">\r\n                                                <option");

WriteLiteral(" ng-disabled=\"!item.available\"");

WriteLiteral(" ng-repeat=\"item in attr.fieldValues\"");

WriteLiteral(" id=\"{{item.fieldValue}}\"");

WriteLiteral(" ng-class=\"item.available==true?\'\':\' grayOut\'\"");

WriteLiteral(" value={{item.fieldValue}}");

WriteLiteral(@">{{item.fieldValue}}</option>
                                            </select>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>  
                        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 107 "..\..\Views\Product\_QuickViewModal.cshtml"
                           Write(Html.Partial("~/Views/Product/_ProductDescription.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n                        </div>             " +
"           \r\n                    </div>\r\n                </div>\r\n               " +
" ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" ng-if=\"pm.model.componentProducts.length > 0\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 115 "..\..\Views\Product\_QuickViewModal.cshtml"
                   Write(Html.Partial("~/Views/Product/_QuickViewBundle.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>         " +
"   \r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
