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
    
    #line 13 "..\..\Views\Search\Search.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 18 "..\..\Views\Search\Search.cshtml"
    using Omnicx.API.SDK.Helpers;
    
    #line default
    #line hidden
    using Omnicx.WebStore;
    using Omnicx.WebStore.Core;
    
    #line 15 "..\..\Views\Search\Search.cshtml"
    using Omnicx.WebStore.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 14 "..\..\Views\Search\Search.cshtml"
    using Omnicx.WebStore.Core.Helpers;
    
    #line default
    #line hidden
    
    #line 16 "..\..\Views\Search\Search.cshtml"
    using Omnicx.WebStore.Framework.Helpers;
    
    #line default
    #line hidden
    
    #line 19 "..\..\Views\Search\Search.cshtml"
    using Omnicx.WebStore.Models.Catalog;
    
    #line default
    #line hidden
    
    #line 17 "..\..\Views\Search\Search.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Search.cshtml")]
    public partial class _Views_Search_Search_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<Omnicx.WebStore.Models.Helpers.PaginatedResult<Omnicx.WebStore.Models.Catalog.ProductModel>>
    {
        public _Views_Search_Search_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Search\Search.cshtml"
  
/*
    Name: Search
    Purpose: Show Product list after search items
    Structure: /Views/Search/Search.cshtml
    Contains (Partial Views Used):
        a-/Views/Shared/_Layout.cshtml
        b-/Views/search/_SearchResultProducts.cshtml

    Contained In (Where we Use this View):      
    */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..\Views\Search\Search.cshtml"
  
    ViewBag.Title = @LT("ProductDetail.Label.Search", "Search");
    Layout = "~/Views/Shared/_Layout.cshtml";

    //Html.AddTitleParts(Model.Name);
    //Html.AddMetaDescriptionParts(Model.MetaDescription);
    //Html.AddMetaKeywordsParts(Model.MetaKeywords);
    //Html.AddCanonicalUrl(Model.CanonicalTags);
    Html.AddDataLayer(DataLayerObjectType.ProductDetail, Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 32 "..\..\Views\Search\Search.cshtml"
Write(Html.Partial("~/Views/search/_SearchResultProducts.cshtml", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n        var searchProductUrl = \'");

            
            #line 35 "..\..\Views\Search\Search.cshtml"
                            Write(Html.BuildUrlFromExpression<SearchController>(c => c.SearchProducts(null)));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var productUrl = \'");

            
            #line 36 "..\..\Views\Search\Search.cshtml"
                      Write(Html.BuildUrlFromExpression<ProductController>(c => c.ProductDetails("")));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var addToWishlistUrl = \'");

            
            #line 37 "..\..\Views\Search\Search.cshtml"
                            Write(Html.BuildUrlFromExpression<AccountController>(c => c.AddProductToWishlist(null)));

            
            #line default
            #line hidden
WriteLiteral("\';     \r\n        var getWishlist = \'");

            
            #line 38 "..\..\Views\Search\Search.cshtml"
                       Write(Html.BuildUrlFromExpression<AccountController>(c => c.GetWishlist()));

            
            #line default
            #line hidden
WriteLiteral(@"'; 
        window.app.constant('productConfig',{
            searchProductUrl:searchProductUrl,
            productUrl : productUrl,
            addToWishlistUrl : addToWishlistUrl,
            getWishlist:getWishlist
        });
        window.app.constant('model', ");

            
            #line 45 "..\..\Views\Search\Search.cshtml"
                                Write(Html.JsonFor(Model));

            
            #line default
            #line hidden
WriteLiteral(");\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591