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
    
    #line 23 "..\..\Views\Account\_SideNav.cshtml"
    using Omnicx.WebStore.Models.Enums;
    
    #line default
    #line hidden
    
    #line 24 "..\..\Views\Account\_SideNav.cshtml"
    using Omnicx.WebStore.Models.Keys;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_SideNav.cshtml")]
    public partial class _Views_Account__SideNav_cshtml : Omnicx.WebStore.Core.Services.Infrastructure.CustomBaseViewPage<dynamic>
    {
        public _Views_Account__SideNav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Account\_SideNav.cshtml"
  
    /*
        Name: Site Nav
        Purpose: List all the Navigation links for desktop and big screen
        Structure: /Views/Account/_SideNav.cshtml
        Contains (Partial Views Used):

        Contained In (Where we Use this View):
            a-/Views/Account/Wishlist.cshtml
            b-/Views/Account/ReturnRequest.cshtml
            c-/Views/Account/ReturnHistory.cshtml
            d-/Views/Account/PasswordChange.cshtml)
            e-/Views/Account/OrderHistory.cshtml
            f-/Views/Account/OrderDetail.cshtml
            g-/Views/Account/MyActivity.cshtml
            h-/Views/Account/MyAccount.cshtml
            i-/Views/Account/AddressBook.cshtml
            j-/Views/B2B/Users.cshtml
            k-/Views/B2B/Quotes.cshtml
            l-/Views/B2B/MyCompany.cshtml
        */

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 27 "..\..\Views\Account\_SideNav.cshtml"
  
    bool isB2B = false;
    CompanyUserRole userRole = CompanyUserRole.None;
    if (SessionContext.CurrentUser != null && this.Request.IsAuthenticated)
    {
        if (SessionContext.CurrentUser.CompanyId != Guid.Empty.ToString())
        {
            isB2B = true;
            userRole = SessionContext.CurrentUser.CompanyUserRole;
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default sidebar-menu\"");

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"panel-body no-padding\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"nav nav-pills nav-stacked\"");

WriteLiteral(">\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1600), Tuple.Create("\"", 1657)
, Tuple.Create(Tuple.Create("", 1611), Tuple.Create("{\'active-ac\'", 1611), true)
, Tuple.Create(Tuple.Create(" ", 1623), Tuple.Create(":\'", 1624), true)
            
            #line 43 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1626), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1626), false)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create("\'==", 1640), true)
, Tuple.Create(Tuple.Create(" ", 1643), Tuple.Create("\'MyAccount\'", 1644), true)
, Tuple.Create(Tuple.Create(" ", 1655), Tuple.Create("}", 1656), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1679), Tuple.Create("\"", 1721)
            
            #line 44 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1686), Tuple.Create<System.Object, System.Int32>(Url.Action("myaccount", "account")
            
            #line default
            #line hidden
, 1686), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 44 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                       Write(LT("MyAccount.Text.Name", "My Account"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");

            
            #line 46 "..\..\Views\Account\_SideNav.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Account\_SideNav.cshtml"
             if (ConfigKeys.DisplayUserActivity)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 1918), Tuple.Create("\"", 1976)
, Tuple.Create(Tuple.Create("", 1929), Tuple.Create("{\'active-ac\'", 1929), true)
, Tuple.Create(Tuple.Create(" ", 1941), Tuple.Create(":\'", 1942), true)
            
            #line 48 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 1944), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 1944), false)
, Tuple.Create(Tuple.Create("", 1958), Tuple.Create("\'==", 1958), true)
, Tuple.Create(Tuple.Create(" ", 1961), Tuple.Create("\'MyActivity\'", 1962), true)
, Tuple.Create(Tuple.Create(" ", 1974), Tuple.Create("}", 1975), true)
);

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2002), Tuple.Create("\"", 2045)
            
            #line 49 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create<System.Object, System.Int32>(Url.Action("myactivity", "account")
            
            #line default
            #line hidden
, 2009), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-clock-o\"");

WriteLiteral("></i>");

            
            #line 49 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                               Write(LT("MyActivity.Text.Name", "My Activity"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 51 "..\..\Views\Account\_SideNav.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2197), Tuple.Create("\"", 2260)
, Tuple.Create(Tuple.Create("", 2208), Tuple.Create("{\'active-ac\'", 2208), true)
, Tuple.Create(Tuple.Create(" ", 2220), Tuple.Create(":\'", 2221), true)
            
            #line 52 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2223), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2223), false)
, Tuple.Create(Tuple.Create("", 2237), Tuple.Create("\'==", 2237), true)
, Tuple.Create(Tuple.Create(" ", 2240), Tuple.Create("\'MySubscriptions\'", 2241), true)
, Tuple.Create(Tuple.Create(" ", 2258), Tuple.Create("}", 2259), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2282), Tuple.Create("\"", 2334)
            
            #line 53 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2289), Tuple.Create<System.Object, System.Int32>(Url.Action("SubscriptionHistory", "account")
            
            #line default
            #line hidden
, 2289), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-cart\"");

WriteLiteral("></i>");

            
            #line 53 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                                          Write(LT("MyAccount.Text.Name", "My Subscriptions"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");

            
            #line 55 "..\..\Views\Account\_SideNav.cshtml"
            
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Account\_SideNav.cshtml"
               if (isB2B)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2531), Tuple.Create("\"", 2588)
, Tuple.Create(Tuple.Create("", 2542), Tuple.Create("{\'active-ac\'", 2542), true)
, Tuple.Create(Tuple.Create(" ", 2554), Tuple.Create(":\'", 2555), true)
            
            #line 57 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2557), false)
, Tuple.Create(Tuple.Create("", 2571), Tuple.Create("\'==", 2571), true)
, Tuple.Create(Tuple.Create(" ", 2574), Tuple.Create("\'MyCompany\'", 2575), true)
, Tuple.Create(Tuple.Create(" ", 2586), Tuple.Create("}", 2587), true)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2618), Tuple.Create("\"", 2656)
            
            #line 58 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2625), Tuple.Create<System.Object, System.Int32>(Url.Action("MyCompany", "b2b")
            
            #line default
            #line hidden
, 2625), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-building\"");

WriteLiteral("></i>");

            
            #line 58 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                               Write(LT("MyAccount.Text.Name", "My Company"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

WriteLiteral("                    <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 2804), Tuple.Create("\"", 2858)
, Tuple.Create(Tuple.Create("", 2815), Tuple.Create("{\'active-ac\'", 2815), true)
, Tuple.Create(Tuple.Create(" ", 2827), Tuple.Create(":\'", 2828), true)
            
            #line 60 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2830), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 2830), false)
, Tuple.Create(Tuple.Create("", 2844), Tuple.Create("\'==", 2844), true)
, Tuple.Create(Tuple.Create(" ", 2847), Tuple.Create("\'Quotes\'", 2848), true)
, Tuple.Create(Tuple.Create(" ", 2856), Tuple.Create("}", 2857), true)
);

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2888), Tuple.Create("\"", 2923)
            
            #line 61 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 2895), Tuple.Create<System.Object, System.Int32>(Url.Action("quotes", "b2b")
            
            #line default
            #line hidden
, 2895), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file\"");

WriteLiteral("></i>");

            
            #line 61 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                        Write(LT("MyAccount.Text.Name", "Quotes"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 63 "..\..\Views\Account\_SideNav.cshtml"
                    if (userRole == (CompanyUserRole.Admin))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3152), Tuple.Create("\"", 3205)
, Tuple.Create(Tuple.Create("", 3163), Tuple.Create("{\'active-ac\'", 3163), true)
, Tuple.Create(Tuple.Create(" ", 3175), Tuple.Create(":\'", 3176), true)
            
            #line 65 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3178), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3178), false)
, Tuple.Create(Tuple.Create("", 3192), Tuple.Create("\'==", 3192), true)
, Tuple.Create(Tuple.Create(" ", 3195), Tuple.Create("\'Users\'", 3196), true)
, Tuple.Create(Tuple.Create(" ", 3203), Tuple.Create("}", 3204), true)
);

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3239), Tuple.Create("\"", 3273)
            
            #line 66 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3246), Tuple.Create<System.Object, System.Int32>(Url.Action("users", "b2b")
            
            #line default
            #line hidden
, 3246), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 66 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                           Write(LT("MyAccount.Text.Name", "My Users"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </li>\r\n");

            
            #line 68 "..\..\Views\Account\_SideNav.cshtml"
                    }
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3470), Tuple.Create("\"", 3598)
, Tuple.Create(Tuple.Create("", 3481), Tuple.Create("{\'active-ac\'", 3481), true)
, Tuple.Create(Tuple.Create(" ", 3493), Tuple.Create(":\'", 3494), true)
            
            #line 72 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3496), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3496), false)
, Tuple.Create(Tuple.Create("", 3510), Tuple.Create("\'==", 3510), true)
, Tuple.Create(Tuple.Create(" ", 3513), Tuple.Create("\'Orders\'||", 3514), true)
, Tuple.Create(Tuple.Create(" ", 3524), Tuple.Create("\'", 3525), true)
            
            #line 72 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3526), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3526), false)
, Tuple.Create(Tuple.Create("", 3540), Tuple.Create("\'==\'Return", 3540), true)
, Tuple.Create(Tuple.Create(" ", 3550), Tuple.Create("Request\'||", 3551), true)
, Tuple.Create(Tuple.Create(" ", 3561), Tuple.Create("\'", 3562), true)
            
            #line 72 "..\..\Views\Account\_SideNav.cshtml"
                            , Tuple.Create(Tuple.Create("", 3563), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3563), false)
, Tuple.Create(Tuple.Create("", 3577), Tuple.Create("\'", 3577), true)
, Tuple.Create(Tuple.Create(" ", 3578), Tuple.Create("==", 3579), true)
, Tuple.Create(Tuple.Create(" ", 3581), Tuple.Create("\'CustomerOrder\'}", 3582), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3620), Tuple.Create("\"", 3665)
            
            #line 73 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3627), Tuple.Create<System.Object, System.Int32>(Url.Action("orderhistory", "account")
            
            #line default
            #line hidden
, 3627), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-shopping-cart\"");

WriteLiteral("></i>");

            
            #line 73 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                                   Write(LT("MyAccount.Links.MyOrders", "My Orders"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");

            
            #line 75 "..\..\Views\Account\_SideNav.cshtml"
            
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Account\_SideNav.cshtml"
             if (userRole == (CompanyUserRole.None) || userRole == (CompanyUserRole.Admin))
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 3918), Tuple.Create("\"", 3978)
, Tuple.Create(Tuple.Create("", 3929), Tuple.Create("{\'active-ac\'", 3929), true)
, Tuple.Create(Tuple.Create(" ", 3941), Tuple.Create(":", 3942), true)
, Tuple.Create(Tuple.Create(" ", 3943), Tuple.Create("\'", 3944), true)
            
            #line 77 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 3945), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 3945), false)
, Tuple.Create(Tuple.Create("", 3959), Tuple.Create("\'", 3959), true)
, Tuple.Create(Tuple.Create(" ", 3960), Tuple.Create("==", 3961), true)
, Tuple.Create(Tuple.Create(" ", 3963), Tuple.Create("\'AddressBook\'}", 3964), true)
);

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4004), Tuple.Create("\"", 4048)
            
            #line 78 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4011), Tuple.Create<System.Object, System.Int32>(Url.Action("AddressBook", "account")
            
            #line default
            #line hidden
, 4011), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-home\"");

WriteLiteral("></i>");

            
            #line 78 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                             Write(LT("MyAccount.Links.AddressBook", "Address Book"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 80 "..\..\Views\Account\_SideNav.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4205), Tuple.Create("\"", 4268)
, Tuple.Create(Tuple.Create("", 4216), Tuple.Create("{\'active-ac\'", 4216), true)
, Tuple.Create(Tuple.Create(" ", 4228), Tuple.Create(":", 4229), true)
, Tuple.Create(Tuple.Create(" ", 4230), Tuple.Create("\'", 4231), true)
            
            #line 81 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4232), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 4232), false)
, Tuple.Create(Tuple.Create("", 4246), Tuple.Create("\'", 4246), true)
, Tuple.Create(Tuple.Create(" ", 4247), Tuple.Create("==", 4248), true)
, Tuple.Create(Tuple.Create(" ", 4250), Tuple.Create("\'Return", 4251), true)
, Tuple.Create(Tuple.Create(" ", 4258), Tuple.Create("History\'}", 4259), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4290), Tuple.Create("\"", 4336)
            
            #line 82 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4297), Tuple.Create<System.Object, System.Int32>(Url.Action("returnhistory", "account")
            
            #line default
            #line hidden
, 4297), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-external-link-square\"");

WriteLiteral("></i>");

            
            #line 82 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                                           Write(LT("MyAccount.Links.ReturnHistory", "Return History"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4494), Tuple.Create("\"", 4549)
, Tuple.Create(Tuple.Create("", 4505), Tuple.Create("{\'active-ac\'", 4505), true)
, Tuple.Create(Tuple.Create(" ", 4517), Tuple.Create(":\'", 4518), true)
            
            #line 84 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4520), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 4520), false)
, Tuple.Create(Tuple.Create("", 4534), Tuple.Create("\'==", 4534), true)
, Tuple.Create(Tuple.Create(" ", 4537), Tuple.Create("\'Wishlist\'}", 4538), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4571), Tuple.Create("\"", 4612)
            
            #line 85 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4578), Tuple.Create<System.Object, System.Int32>(Url.Action("wishlist", "account")
            
            #line default
            #line hidden
, 4578), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-heart\"");

WriteLiteral("></i>");

            
            #line 85 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                       Write(LT("MyAccount.Links.Wishlist", "My Wishlist"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 4749), Tuple.Create("\"", 4810)
, Tuple.Create(Tuple.Create("", 4760), Tuple.Create("{\'active-ac\'", 4760), true)
, Tuple.Create(Tuple.Create(" ", 4772), Tuple.Create(":\'", 4773), true)
            
            #line 88 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4775), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 4775), false)
, Tuple.Create(Tuple.Create("", 4789), Tuple.Create("\'==\'Change", 4789), true)
, Tuple.Create(Tuple.Create(" ", 4799), Tuple.Create("Password\'}", 4800), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4832), Tuple.Create("\"", 4880)
            
            #line 89 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 4839), Tuple.Create<System.Object, System.Int32>(Url.Action("PasswordChange" , "account")
            
            #line default
            #line hidden
, 4839), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-key\"");

WriteLiteral("></i>");

            
            #line 89 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                            Write(LT("Global.Buttons.PasswordChange", "Change Password"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li");

WriteAttribute("ng-class", Tuple.Create(" ng-class=\"", 5022), Tuple.Create("\"", 5086)
, Tuple.Create(Tuple.Create("", 5033), Tuple.Create("{\'active-ac\'", 5033), true)
, Tuple.Create(Tuple.Create(" ", 5045), Tuple.Create(":\'", 5046), true)
            
            #line 91 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 5048), Tuple.Create<System.Object, System.Int32>(ViewBag.Title
            
            #line default
            #line hidden
, 5048), false)
, Tuple.Create(Tuple.Create("", 5062), Tuple.Create("\'==", 5062), true)
, Tuple.Create(Tuple.Create(" ", 5065), Tuple.Create("\'Personality", 5066), true)
, Tuple.Create(Tuple.Create(" ", 5078), Tuple.Create("Quiz\'", 5079), true)
, Tuple.Create(Tuple.Create(" ", 5084), Tuple.Create("}", 5085), true)
);

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5108), Tuple.Create("\"", 5155)
            
            #line 92 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 5115), Tuple.Create<System.Object, System.Int32>(Url.Action("surveyresponse", "account")
            
            #line default
            #line hidden
, 5115), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>");

            
            #line 92 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                            Write(LT("MyAccount.Text.PersonalityQuiz", "Personality Quiz"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n            <li>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5321), Tuple.Create("\"", 5360)
            
            #line 95 "..\..\Views\Account\_SideNav.cshtml"
, Tuple.Create(Tuple.Create("", 5328), Tuple.Create<System.Object, System.Int32>(Url.Action("logout", "account")
            
            #line default
            #line hidden
, 5328), false)
);

WriteLiteral(" class=\"color-black\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-sign-out\"");

WriteLiteral("></i>");

            
            #line 95 "..\..\Views\Account\_SideNav.cshtml"
                                                                                                        Write(LT("Global.Buttons.Logout", "LogOut"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591