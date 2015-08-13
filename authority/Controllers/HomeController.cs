using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            {
                var res = DB.SExecuteReader("select id from " + DBTables.QnA +" order by createtime desc limit 6");
                var list = new List<DBC.QnA>();
                foreach (var item in res)
                {
                    var qna = new DBC.QnA(Convert.ToInt32(item[0]));
                    list.Add(qna);
                }
                ViewBag.qnaList = list;
            }
            {
                var res = DB.SExecuteReader("select id from " + DBTables.Announcement +" order by createtime desc limit 6");
                var list=new List<DBC.Announcement>();
                foreach (var item in res)
	        {
                    var announcement = new DBC.Announcement(Convert.ToInt32(item[0]));
                    list.Add(announcement);
	        }
                ViewBag.announcementlist = list;
            }
            {
                var res = DB.SExecuteReader("select id from " + DBTables.Article + " order by createtime desc limit 6");
                var list = new List<DBC.Article>();
                foreach (var item in res)
                {
                    var article = new DBC.Article(Convert.ToInt32(item[0]));
                    list.Add(article);
                }
                ViewBag.articlelist = list;
            }
            return View();
        }
    }
}
