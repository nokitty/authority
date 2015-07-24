using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    [LoginCheck]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Role()
        {            
            return View();
        }

        public ActionResult RoleAdd()
        {
            return View();
        }
    }
}
