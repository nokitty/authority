using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class AnnouncementController : Controller
    {
        //
        // GET: /Announcement/

        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult list()
        {
            {
                var res = DB.SExecuteReader("select id from " + DBTables.Announcement + " order by createtime desc limit 5");
                var list = new List<DBC.Announcement>();
                foreach (var item in res)
                {
                    var announcement = new DBC.Announcement(Convert.ToInt32(item[0]));
                    list.Add(announcement);
                }
                ViewBag.announcementlist = list;
            }
            return View("test_list");
        }

        public ActionResult Details(int id)
        {
            var announcement = new DBC.Announcement(id);
            ViewBag.announcement = announcement;
            return View("test_details");
        }
    }
}
