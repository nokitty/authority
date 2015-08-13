using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class SignupController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "注册";

            if (Session["user"] != null)
                return Content("已经登录不能操作");

            if (Request.HttpMethod == "POST")
            {
                var tel = Request.Form["tel"];
                var password = Request.Form["password"];

                try
                {
                    var userid = DB.SInsert("insert into " + DBTables.User + " (tel,password) values (?,?)", tel, password.SHA256());
                    var user = new DBC.User(userid);
                    Session["user"] = user;

                    return Content("注册成功");
                }
                catch
                {
                    return Content("该用户名已经被注册");
                }
            }
            return View("pc_regist");
        }

    }
}
