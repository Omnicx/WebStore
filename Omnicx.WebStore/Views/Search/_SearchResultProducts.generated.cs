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
    
    #line 20 "..\..\Views\Search\_SearchResultProducts.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 22 "..\..\Views\Search\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 21 "..\..\Views\Search\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 23 "..\..\Views\Search\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 24 "..\..\Views\Search\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Models.Catalog;
    
    #line default
    #line hidden
    
    #line 25 "..\..\Views\Search\_SearchResultProducts.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/_SearchResultProducts.cshtml")]
    public partial class _Views_Search__SearchResultProducts_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Helpers.PaginatedResult<Omnicx.WebStore.Models.Catalog.ProductModel>>
    {
        public _Views_Search__SearchResultProducts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\_SearchResultProducts.cshtml"
  
/*
    Name: Search Result
    Purpose: Show Product list after search Result
    Structure: /Views/Search/_SearchResultProducts.cshtml
    Contains (Partial Views Used):
        a-/Views/Search/_SearchFacetsMobile.cshtml
        b-/Views/Search/_SearchFacets.cshtml
        c-/Views/Search/_SearchTopBar.cshtml
        d-/Views/Search/_NoResults.cshtml
        e-/Views/Search/_ProductWidget.cshtml
        f-/Views/Search/_ProductListWidget.cshtml
        g-/Views/Search/_SearchBottomBar.cshtml
        h-/Views/Product/_QuickViewModal.cshtml

    Contained In (Where we Use this View):
        a-/Views/Search/Search.cshtml
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n<section");

WriteLiteral(" ng-controller=\"productCtrl as pm\"");

WriteAttribute("ng-init", Tuple.Create(" ng-init=\'", 1097), Tuple.Create("\'", 1217)
, Tuple.Create(Tuple.Create("", 1107), Tuple.Create("pm.initProducts(", 1107), true)
            
            #line 30 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 1123), Tuple.Create<System.Object, System.Int32>(Html.Json(Model)
            
            #line default
            #line hidden
, 1123), false)
, Tuple.Create(Tuple.Create("", 1140), Tuple.Create(");pm.getView=pm.getViewBycookie;pm.getToWishlist(pm.productResponse.results);", 1140), true)
);

WriteLiteral(">\r\n\r\n");

            
            #line 32 "..\..\Views\Search\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Search\_SearchResultProducts.cshtml"
       /* Start WishList Validations */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-success wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlistsaved\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 34 "..\..\Views\Search\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AddToWishlist", "Product added to wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlistexistserror\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 37 "..\..\Views\Search\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AlreadyAddedToWishlist", "Product already added in wishlist"));

            
            #line default
            #line hidden
WriteLiteral("!</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.maximumWishlisterror\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 40 "..\..\Views\Search\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AddedMaximumWishlistItems", " You have reached the maximum limit"));

            
            #line default
            #line hidden
WriteLiteral("!</strong>\r\n    </div>\r\n    <div ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"pm.wishlisterror\"");

WriteLiteral(">\r\n        User <strong>");

            
            #line 43 "..\..\Views\Search\_SearchResultProducts.cshtml"
                Write(LT("ProductDetail.Message.LoginRequired", "Login Required"));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </div>\r\n    <span ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"gm.maximumBasketItemError\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 46 "..\..\Views\Search\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AddedMaximumBasketItems", "You Reached Maximum Add To Bag Limit "));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" ng-bind=\"gm.maximumAddToBasketLimit\"");

WriteLiteral("></span></strong>\r\n    </span>\r\n    <span ng-cloak");

WriteLiteral(" class=\"alert alert-danger wishdiv alert-pos\"");

WriteLiteral(" ng-show=\"gm.maximumBasketsubscriptionItemError\"");

WriteLiteral(">\r\n        <strong>");

            
            #line 49 "..\..\Views\Search\_SearchResultProducts.cshtml"
           Write(LT("ProductDetail.Message.AddedMaximumBasketSubscriptionItems", "You cannot add more Subscription Products, Maximum limit exceed : "));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    </span>\r\n");

            
            #line 51 "..\..\Views\Search\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Search\_SearchResultProducts.cshtml"
       /*  End WishList Validations */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 53 "..\..\Views\Search\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Search\_SearchResultProducts.cshtml"
       /* Start products container */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 visible-xs\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 56 "..\..\Views\Search\_SearchResultProducts.cshtml"
       Write(Html.Partial("~/Views/Search/_SearchFacetsMobile.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-sm-3 col-md-3 col-lg-2 no-padding hidden-xs\"");

WriteLiteral(">\r\n");

            
            #line 59 "..\..\Views\Search\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Search\_SearchResultProducts.cshtml"
              
                /* Start left filter grid */
                var listClass = "col-sm-12 col-xs-12 d--no-padding";
            
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 63 "..\..\Views\Search\_SearchResultProducts.cshtml"
            
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Search\_SearchResultProducts.cshtml"
             if (Model.Results != null && Model.Results.Count != 0 && Model.SearchCriteria.AllowFacet)
            {
                listClass = "col-sm-9 col-md-9 col-lg-10 col-xs-12 d--no-padding-right";

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-sm-12 filterContainer sm\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 67 "..\..\Views\Search\_SearchResultProducts.cshtml"
               Write(Html.Partial("~/Views/Search/_SearchFacets.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 69 "..\..\Views\Search\_SearchResultProducts.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 70 "..\..\Views\Search\_SearchResultProducts.cshtml"
               /* End left filter grid */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3619), Tuple.Create("\"", 3637)
            
            #line 72 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 3627), Tuple.Create<System.Object, System.Int32>(listClass
            
            #line default
            #line hidden
, 3627), false)
);

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 dataContainer sm\"");

WriteLiteral(">\r\n\r\n");

            
            #line 75 "..\..\Views\Search\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Search\_SearchResultProducts.cshtml"
                  
                    if (Model.Images != null && Model.Images.Any())
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 clearfix margin-bottom-lg no-padding\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" id=\"carousel-example-generic\"");

WriteLiteral(" class=\"carousel slide omnicomponent component-slider\"");

WriteLiteral(" list-id=\"\"");

WriteLiteral(" list-type=\"\"");

WriteLiteral(" data-ride=\"carousel\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"carousel-inner\"");

WriteLiteral(">\r\n");

            
            #line 81 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 81 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                     foreach (var img in Model.Images.Select((obj, index) => new { index, obj }))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <div");

WriteLiteral(" class=\"item\"");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4352), Tuple.Create("\"", 4387)
, Tuple.Create(Tuple.Create("", 4363), Tuple.Create("{active", 4363), true)
, Tuple.Create(Tuple.Create(" ", 4370), Tuple.Create(":", 4371), true)
            
            #line 83 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create(" ", 4372), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 4373), false)
, Tuple.Create(Tuple.Create("", 4383), Tuple.Create("==0}", 4383), true)
);

WriteLiteral(">\r\n");

            
            #line 84 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                            
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                             if (img.obj.LinkType == LinkType.Href.GetHashCode().ToString())
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4598), Tuple.Create("\"", 4618)
            
            #line 86 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 4605), Tuple.Create<System.Object, System.Int32>(img.obj.Link
            
            #line default
            #line hidden
, 4605), false)
);

WriteLiteral(">\r\n                                                    <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 4678), Tuple.Create("\"", 4699)
            
            #line 87 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 4687), Tuple.Create<System.Object, System.Int32>(img.obj.Url
            
            #line default
            #line hidden
, 4687), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 4700), Tuple.Create("\"", 4734)
, Tuple.Create(Tuple.Create("", 4706), Tuple.Create("Slide", 4706), true)
            
            #line 87 "..\..\Views\Search\_SearchResultProducts.cshtml"
         , Tuple.Create(Tuple.Create(" ", 4711), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 4712), false)
, Tuple.Create(Tuple.Create(" ", 4722), Tuple.Create("of", 4723), true)
, Tuple.Create(Tuple.Create(" ", 4725), Tuple.Create("Carousel", 4726), true)
);

WriteLiteral(" class=\"img-responsive image1\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n                                                    <div");

WriteLiteral(" class=\"component-static-html img-topData hidden-xs\"");

WriteLiteral(">\r\n                                                        <h2>");

            
            #line 89 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                       Write(img.obj.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                                        <h3>");

            
            #line 90 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                       Write(img.obj.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                                        <p");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">");

            
            #line 91 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                                         Write(img.obj.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                    </div>\r\n               " +
"                                 </a>\r\n");

            
            #line 94 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <img");

WriteAttribute("ng-src", Tuple.Create(" ng-src=\"", 5497), Tuple.Create("\"", 5518)
            
            #line 97 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 5506), Tuple.Create<System.Object, System.Int32>(img.obj.Url
            
            #line default
            #line hidden
, 5506), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 5519), Tuple.Create("\"", 5553)
, Tuple.Create(Tuple.Create("", 5525), Tuple.Create("Slide", 5525), true)
            
            #line 97 "..\..\Views\Search\_SearchResultProducts.cshtml"
     , Tuple.Create(Tuple.Create(" ", 5530), Tuple.Create<System.Object, System.Int32>(img.index
            
            #line default
            #line hidden
, 5531), false)
, Tuple.Create(Tuple.Create(" ", 5541), Tuple.Create("of", 5542), true)
, Tuple.Create(Tuple.Create(" ", 5544), Tuple.Create("Carousel", 5545), true)
);

WriteLiteral(" class=\"img-responsive image1\"");

WriteLiteral(" onerror=\"this.src = DEFAULT_IMAGE_URL\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                <div");

WriteLiteral(" class=\"component-static-html img-topData hidden-xs\"");

WriteLiteral(">\r\n                                                    <h2>");

            
            #line 99 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                   Write(img.obj.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                                    <h3>");

            
            #line 100 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                   Write(img.obj.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                                                    <p>");

            
            #line 101 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                  Write(img.obj.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                                    <p>\r\n");

            
            #line 103 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                        
            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                         if (img.obj.LinkType == LinkType.Button.GetHashCode().ToString())
                                                        {

            
            #line default
            #line hidden
WriteLiteral("                                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6273), Tuple.Create("\"", 6293)
            
            #line 105 "..\..\Views\Search\_SearchResultProducts.cshtml"
, Tuple.Create(Tuple.Create("", 6280), Tuple.Create<System.Object, System.Int32>(img.obj.Link
            
            #line default
            #line hidden
, 6280), false)
);

WriteLiteral(" class=\"shop-now\"");

WriteLiteral("> ");

            
            #line 105 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                                                                 Write(img.obj.ButtonText);

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n");

            
            #line 106 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                        }

            
            #line default
            #line hidden
WriteLiteral("                                                    </p>\r\n                       " +
"                         </div>\r\n");

            
            #line 109 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </div>\r\n");

            
            #line 112 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div><a");

WriteLiteral(" class=\"left carousel-control\"");

WriteLiteral(" href=\"#carousel-example-generic\"");

WriteLiteral(" data-slide=\"prev\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"fa fa-chevron-left\"");

WriteLiteral("></span>\r\n                                </a>\r\n                                <" +
"a");

WriteLiteral(" class=\"right carousel-control\"");

WriteLiteral(" href=\"#carousel-example-generic\"");

WriteLiteral(" data-slide=\"next\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"fa fa-chevron-right\"");

WriteLiteral("></span>\r\n                                </a>\r\n                            </div" +
">\r\n                        </div>\r\n");

            
            #line 121 "..\..\Views\Search\_SearchResultProducts.cshtml"
                    }
                
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 123 "..\..\Views\Search\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\Search\_SearchResultProducts.cshtml"
                   /* Start Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 124 "..\..\Views\Search\_SearchResultProducts.cshtml"
           Write(Html.Partial("~/Views/Search/_SearchTopBar.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 125 "..\..\Views\Search\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\Search\_SearchResultProducts.cshtml"
                   /* End Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n                ");

WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 129 "..\..\Views\Search\_SearchResultProducts.cshtml"
               Write(Html.Partial("~/Views/Search/_NoResults.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                    ");

WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 gridView no-padding\"");

WriteLiteral(" id=\"view\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"panel-group\"");

WriteLiteral(" id=\"accordion1{{$index}}\"");

WriteLiteral(" role=\"tablist\"");

WriteLiteral(" aria-multiselectable=\"true\"");

WriteLiteral(" ng-repeat=\"grp in pm.productResponse.groupsWithProducts track by $index\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"panel panel-default margin-bottom-lg no-border\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(" role=\"tab\"");

WriteLiteral(" id=\"heading1{{$index}}\"");

WriteLiteral(">\r\n                                    <h4");

WriteLiteral(" class=\"panel-title heading-h4 no-border no-padding\"");

WriteLiteral(">\r\n                                        <a");

WriteLiteral(" role=\"button\"");

WriteLiteral(" class=\"no-padding\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-parent=\"#accordion1{{$index}}\"");

WriteLiteral(" href=\"#Data1{{$index}}\"");

WriteLiteral(" aria-expanded=\"true\"");

WriteLiteral(" aria-controls=\"Data{{$index}}\"");

WriteLiteral(" ng-bind=\"grp.groupName\"");

WriteLiteral("></a>\r\n                                    </h4>\r\n");

            
            #line 139 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 139 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                     if (Model.ProductGroupModel != null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <div");

WriteLiteral(" class=\"col-sm-12 col-xs-12 no-padding groupSeparator\"");

WriteLiteral(" ng-hide=\"grp.groupName==\'\'\"");

WriteLiteral(">");

            
            #line 141 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                                                                                                          Write(Html.Raw(Model.ProductGroupModel.GroupSeparator));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 142 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div>\r\n                                <div");

WriteLiteral(" id=\"Data1{{$index}}\"");

WriteLiteral(" class=\"panel-collapse collapse in\"");

WriteLiteral(" role=\"tabpanel\"");

WriteLiteral(" aria-labelledby=\"heading1{{$index}}\"");

WriteLiteral("  ng-controller=\"subscriptionCtrl as sm\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"panel-body no-padding no-border\"");

WriteLiteral(">\r\n                                        ");

WriteLiteral("\r\n                                        <div");

WriteLiteral(" class=\"col-md-5ths col-sm-5ths col-xs-5ths col-lg-5ths resultContainerRelated\"");

WriteLiteral(" ng-repeat=\"product in grp.products track by $index\"");

WriteLiteral(" ng-cloak>\r\n");

WriteLiteral("                                            ");

            
            #line 148 "..\..\Views\Search\_SearchResultProducts.cshtml"
                                       Write(Html.Partial("~/Views/Search/_ProductWidget.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </div>\r\n                               " +
"     </div>\r\n                                </div>\r\n                           " +
" </div>\r\n                        </div>\r\n                    </div>\r\n           " +
"     </div>\r\n");

            
            #line 156 "..\..\Views\Search\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 156 "..\..\Views\Search\_SearchResultProducts.cshtml"
                   /*End product listing row*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 158 "..\..\Views\Search\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 158 "..\..\Views\Search\_SearchResultProducts.cshtml"
                   /* Start Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 159 "..\..\Views\Search\_SearchResultProducts.cshtml"
                
            
            #line default
            #line hidden
            
            #line 159 "..\..\Views\Search\_SearchResultProducts.cshtml"
                 if (Model.Results != null && Model.Results.Count != 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" ng-hide=\"pm.productResponse == null || pm.productResponse.results==null||pm.prod" +
"uctResponse.total==0\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 162 "..\..\Views\Search\_SearchResultProducts.cshtml"
                   Write(Html.Partial("~/Views/Search/_SearchBottomBar.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 164 "..\..\Views\Search\_SearchResultProducts.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 165 "..\..\Views\Search\_SearchResultProducts.cshtml"
                   /* End Product sorting and pagination partial view */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 169 "..\..\Views\Search\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 169 "..\..\Views\Search\_SearchResultProducts.cshtml"
       /* End products container */ 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 171 "..\..\Views\Search\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 171 "..\..\Views\Search\_SearchResultProducts.cshtml"
       /*Start Product quick view detail popup*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 172 "..\..\Views\Search\_SearchResultProducts.cshtml"
Write(Html.Partial("~/Views/Product/_QuickViewModal.cshtml", new ProductDetailModel { }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 173 "..\..\Views\Search\_SearchResultProducts.cshtml"
    
            
            #line default
            #line hidden
            
            #line 173 "..\..\Views\Search\_SearchResultProducts.cshtml"
       /*End detail popup*/ 
            
            #line default
            #line hidden
WriteLiteral("\r\n</section>\r\n");

        }
    }
}
#pragma warning restore 1591
