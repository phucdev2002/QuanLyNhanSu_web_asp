//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Delete_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Delete_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden

#line 3 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayNameFor(model => model.LoaiHD);


#line default
#line hidden

#line 4 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayFor(model => model.LoaiHD);


#line default
#line hidden

#line 5 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayNameFor(model => model.TuNgay);


#line default
#line hidden

#line 6 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayFor(model => model.TuNgay);


#line default
#line hidden

#line 7 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayNameFor(model => model.DenNgay);


#line default
#line hidden

#line 8 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayFor(model => model.DenNgay);


#line default
#line hidden

#line 9 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayNameFor(model => model.NhanVien.HoTen);


#line default
#line hidden

#line 10 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.DisplayFor(model => model.NhanVien.HoTen);


#line default
#line hidden

#line 11 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
    using (Html.BeginForm()) {
        

#line default
#line hidden

#line 12 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
   __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 13 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
                                

        

#line default
#line hidden

#line 14 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
       __o = Html.ActionLink("Back to List", "Index");


#line default
#line hidden

#line 15 "C:\Users\ASUS\AppData\Local\Temp\0E98AC741E019D68503D515728FB28527F1C\4\QuanLyNhanSu\Views\HopDongs\Delete.cshtml"
              
    }

#line default
#line hidden
}
}
}
