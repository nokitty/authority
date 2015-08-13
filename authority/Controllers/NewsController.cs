using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/

        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult List()
        {
            {
                var res = DB.SExecuteReader("select id from " + DBTables.Article + " order by createtime desc limit 5");
                var list = new List<DBC.Article>();
                foreach (var item in res)
                {
                    var article = new DBC.Article(Convert.ToInt32(item[0]));
                    list.Add(article);
                }
                ViewBag.articlelist = list;
            }
            return View("test_list");
        }

        public ActionResult Details(int id)
        {
            var news = new DBC.Article(id);
            ViewBag.news = news;
            return View("test_details");
        }
    }
}
