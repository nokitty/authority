using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                try
                {
                    var val = Request.Cookies["login"].Value;
                    var res = DB.SExecuteScalar("select userid from user_login_cookie where value=?", val);
                    if (res != null)
                    {
                        var userid = Convert.ToInt32(res);
                        var user = new DBC.User(userid);
                    }
                }
                catch
                {
                    HttpCookie cookie = new HttpCookie("login");
                    cookie.Value = Guid.NewGuid().ToString("d");
                    cookie.HttpOnly = true;
                    Response.SetCookie(cookie);
                }
            }
            else
            {

            }
            return Content("ok");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Regist()
        {
            return View();
        }
        public ActionResult RegistResult()
        {
            try
            {
                var tel = Request.Form["tel"];
                var password = Request.Form["password"];
                var name = Request.Form["name"];

                DBC.User.Create(tel, password, name);

                return Content("创建成功!");
            }
            catch
            {
                return Content("该用户已经创建过");
            }
        }
        public ActionResult LoginResult()
        {
            var tel = Request.Form["tel"];
            var password = Request.Form["password"];

            DBC.User.Login(tel,password);
            return Content("");
        }
    }
}
