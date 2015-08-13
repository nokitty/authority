using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    public class QnAController : Controller
    {
        //
        // GET: /QnA/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult list()
        {
            {
                var res = DB.SExecuteReader("select id from " + DBTables.QnA + " order by createtime desc limit 5");
                var list = new List<DBC.QnA>();
                foreach (var item in res)
                {
                    var qna = new DBC.QnA(Convert.ToInt32(item[0]));
                    list.Add(qna);
                }
                ViewBag.qnalist = list;
            }
            return View("test_list");
        }
    }
}
