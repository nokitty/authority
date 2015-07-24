using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;


namespace authority.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            if (Session["user"] != null)
                return Content("已经登录过了,请不要重复登录");

            if (Request.HttpMethod == "POST")
            {
                var tel = Request.Form["tel"];
                var password = Request.Form["password"];                

                var sql = "select id from " + DBTables.User + " where tel=? and password=?";
                var pw = password.SHA256();
                var res = DB.SExecuteScalar(sql, tel, password.SHA256());

                if (res == null)
                    return Content("帐号或密码错误");

                var userid = Convert.ToInt32(res);
                Session["user"] = new DBC.User(userid);

                if (string.IsNullOrEmpty(Request.Form["remember"]) == false)
                {
                    HttpCookie cookie = new HttpCookie("login");
                    var val = Guid.NewGuid().ToString("d");

                    DB.SExecuteNonQuery("insert into "+DBTables.UserLoginCookie +"(userid,value) values (?,?)" ,userid,val);

                    cookie.Value = Guid.NewGuid().ToString("d");
                    cookie.Expires = DateTime.Now.AddDays(15);
                    cookie.HttpOnly = true;

                    Response.SetCookie(cookie);
                }
            }
            return View();
        }

    }
}
