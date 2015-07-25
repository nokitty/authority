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
        [LoginCheck]
        public ActionResult Index()
        {
            ViewBag.Title = "个人信息";
            return View();
        }

    }
}
