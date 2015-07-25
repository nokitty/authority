using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class LogoutController : Controller
    {
        [LoginCheck]
        public ActionResult Index()
        {
            var user = Session["user"] as DBC.User;
            var sql="delete from "+DBTables.UserLoginCookie+" where userid=?";
            DB.SExecuteNonQuery(sql, user.ID);
            
            Session.Remove("user");
            Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
            return Redirect("~/");
        }
    }
}
