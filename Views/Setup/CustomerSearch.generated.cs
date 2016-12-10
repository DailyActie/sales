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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Sales;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/CustomerSearch.cshtml")]
    public partial class _Views_Setup_CustomerSearch_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_CustomerSearch_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\CustomerSearch.cshtml"
  
    ViewBag.Title = "Customers";
    Layout = ViewBag.SalesLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <title>Customers</title>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <script");

WriteLiteral(" src=\"/i18n/resources.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/assets/js/backend.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Scripts/inflection-js/inflection.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/localizable.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/validator.js\"");

WriteLiteral("></script>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"/Scripts/semantic-ui/semantic.min.css\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"/dashboard/my/template/Contents/dashboard.css\"");

WriteLiteral("/>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 698), Tuple.Create("\"", 749)
, Tuple.Create(Tuple.Create("", 704), Tuple.Create<System.Object, System.Int32>(Href("~/dashboard/my/template/Contents/dashboard.js")
, 704), false)
);

WriteLiteral("></script>\r\n    <style>\r\n        html, body {\r\n            font-size: 12px;\r\n    " +
"    }\r\n    </style>\r\n</head>\r\n<body>\r\n\r\n    <script>\r\n        var scrudFactory =" +
" new Object();\r\n\r\n        scrudFactory.title = \"Customers\";\r\n\r\n        scrudFact" +
"ory.viewAPI = \"/api/views/inventory/customer-scrud-view\";\r\n        scrudFactory." +
"viewTableName = \"inventory.customers\";\r\n\r\n        scrudFactory.formAPI = \"/api/f" +
"orms/inventory/customers\";\r\n        scrudFactory.formTableName = \"inventory.cust" +
"omers\";\r\n\r\n        scrudFactory.uploadHanlder = \"/dashboard/inventory/services/a" +
"ttachments\";\r\n\r\n        scrudFactory.excludedColumns = [\"audit_user_id\", \"audit_" +
"ts\"];\r\n\r\n        scrudFactory.allowDelete = true;\r\n        scrudFactory.allowEdi" +
"t = true;\r\n\r\n        scrudFactory.live = \"CustomerName\";\r\n\r\n\r\n        scrudFacto" +
"ry.layout = [\r\n            {\r\n                tab: \"\",\r\n                fields: " +
"[\r\n                    [\"CustomerId\", \"\"],\r\n                    [\"Photo\", \"\"],\r\n" +
"                    [\"CustomerCode\", \"CustomerName\"],\r\n                    [\"Cus" +
"tomerTypeId\", \"\"],\r\n                    [\"Logo\", \"\"]\r\n                ]\r\n       " +
"     }\r\n        ];\r\n\r\n        scrudFactory.keys = [\r\n            {\r\n            " +
"    property: \"CustomerTypeId\",\r\n                url: \'/api/forms/inventory/cust" +
"omer-types/display-fields\',\r\n                data: null,\r\n                valueF" +
"ield: \"Key\",\r\n                textField: \"Value\"\r\n            }\r\n        ];\r\n\r\n\r" +
"\n        var selectButton = $(\"<button class=\'ui basic button\' id=\'SelectButton\'" +
">Select & Close</button>\");\r\n        var useButton = $(\"<button class=\'ui blue b" +
"utton\' id=\'UseButton\'>Use</button>\");\r\n        var scrudSaveButtonCallback = und" +
"efined;\r\n\r\n        $.get(\'/ScrudFactory/View.html\', function (view) {\r\n         " +
"   $.get(\'/ScrudFactory/Form.html\', function (form) {\r\n                $(\"#Scrud" +
"FactoryView\").html(view);\r\n                $(\"#ScrudFactoryForm\").html(form);\r\n\r" +
"\n                $(\".filter.column\").hide();\r\n                $(\".scrud-grid.col" +
"umn\").removeClass(\"thirteen wide\").addClass(\"sixteen wide\");\r\n\r\n\r\n              " +
"  $(\"#AddNewButton\").after(selectButton);\r\n                $(\"#SaveButton\").befo" +
"re(useButton);\r\n\r\n                $.cachedScript(\"/assets/js/scrudfactory-view.j" +
"s\");\r\n                $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n      " +
"      });\r\n        });\r\n\r\n        selectButton.click(function() {\r\n            c" +
"onst customerId = window.getSelected();\r\n            const tr = $(\"table#ScrudVi" +
"ew input:checkbox:checked\").first().closest(\"tr\");\r\n            const customerCo" +
"de = tr.find(\"td:eq(3)\").html();\r\n\r\n            parent.onCustomerSearchSelect(cu" +
"stomerId, customerCode);\r\n        });\r\n\r\n        useButton.click(function () {\r\n" +
"            scrudSaveButtonCallback = function (customerId) {\r\n                c" +
"onst parent = window.parent;\r\n                parent.onCustomerSearchSelect(cust" +
"omerId);\r\n            };\r\n\r\n            $(\"#SaveButton\").trigger(\"click\");\r\n    " +
"    });\r\n\r\n    </script>\r\n\r\n    <div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591