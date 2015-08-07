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
                var res = DB.SExecuteReader("select id from " + DBTables.QnA);
                var list = new List<DBC.QnA>();
                foreach (var item in res)
                {
                    var qna = new DBC.QnA(Convert.ToInt32(item[0]));
                    list.Add(qna);
                }
                ViewBag.qnaList = list;
            }
            return View();
        }
    }
}
