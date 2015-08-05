using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    [LoginCheck(Order=0)]
    [AuthorityCheck("Admin.Access",Order=1)]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        #region 角色管理
        [AuthorityCheck("Role.Access")]
        public ActionResult Role()
        {            
            ViewBag.Title2 = "角色管理";
            var res = DB.SExecuteReader("select id from role");
            var list = new List<DBC.Role>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.Role(id));
            }

            ViewBag.list = list;
            return View();
        }

        [AuthorityCheck("Role.Access")]
        public ActionResult RoleCreate()
        {
            if (Request.HttpMethod == "POST")
            {
                var name = Request.Form["name"];
                var description = Request.Form["description"];
                var role = DBC.Role.Create(name, description);

                var sql = "select code from " + DBTables.Authority;
                var res = DB.SExecuteReader(sql);
                foreach (var item in res)
                {
                    var code = (string)item[0];
                    //var value = Request.Form[code];
                }

                return View();
            }
            else
            {
                ViewBag.RoleCreate = true;
                ViewBag.Title2 = "角色管理-添加新角色";

                var sql = "select id from " + DBTables.Authority;
                var res = DB.SExecuteReader(sql);

                var list = new List<DBC.Authority>();
                foreach (var item in res)
                {
                    var id = Convert.ToInt32(item[0]);
                    list.Add(new DBC.Authority(id));
                }

                ViewBag.list = list;
                return View("roledetail");
            }
        }

        [AuthorityCheck("Role.Access")]
        public ActionResult RoleEdit()
        {
            ViewBag.Title2 = "权限管理--修改";
            ViewBag.RoleEdit = true;

            //后续修改
            var sql = "select id from " + DBTables.Authority;
            var res = DB.SExecuteReader(sql);

            var list = new List<DBC.Authority>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.Authority(id));
            }

            ViewBag.list = list;
            //后续修改

            return View("roledetail");
        }

        [AuthorityCheck("Role.Access")]
        public ActionResult RoleShow()
        {
            ViewBag.Title2 = "权限管理--详情";
            ViewBag.RoleShow = true;

            //后续修改
            var sql = "select id from " + DBTables.Authority;
            var res = DB.SExecuteReader(sql);

            var list = new List<DBC.Authority>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.Authority(id));
            }

            ViewBag.list = list;
            //后续修改

            return View("roledetail");
        } 
        #endregion

        #region 举报管理
        public ActionResult Report()
        {
            ViewBag.Title2 = "举报管理";
            var res = DB.SExecuteReader("select id from "+DBTables.ReportedPerson);
            var list = new List<DBC.ReportedPerson>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.ReportedPerson(id));
            }
            ViewBag.list = list;
            return View();
        }

        //修改（只能修改审核状态，其他信息不能修改）
        [HttpGet]
        public ActionResult ReportEdit(int id)
        {
            ViewBag.Title2 = "审核管理-审核验证";
            var ann = new DBC.ReportedPerson(id);
            ViewBag.reportedperson = ann;
            return View("Check");
        }
        [HttpPost]
        public  ActionResult ReportEdit(int id,ReportedPersonCheckStates state)
        {
            
            var ann = new DBC.ReportedPerson(id);
            ann.CheckState =(byte) state;
            return Redirect("~/admin/Report");
        }

        //删除
        public ActionResult ReportDelete(int id)
        {
            var ann = new DBC.ReportedPerson(id);
            ann.Delete();
            return Redirect("~/admin/Report");
        }
        #endregion

        #region 公告管理
        public ActionResult Announcement()
        {
            ViewBag.Title2 = "公告管理";
            var res = DB.SExecuteReader("select id from announcement");
            var list = new List<DBC.Announcement>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.Announcement(id));
            }
            ViewBag.list = list;
            return View();
        }

        [HttpGet]
        public ActionResult AnnouncementAdd()
        {
            ViewBag.AnnouncementAdd = true;
            ViewBag.Title2 = "公告管理-添加公告";

            return View("antwrite");
        }
        [HttpPost]
        public ActionResult AnnouncementAdd(string title, string content)
        {
            DBC.Announcement.Create(title, content);

            return Redirect("~/admin/Announcement");
        }
        [HttpGet]
        public ActionResult AnnouncementEdit(int id)
        {
            ViewBag.AnnouncementAdd = true;
            ViewBag.Title2 = "公告管理-修改公告";

            var ann = new DBC.Announcement(id);
            ViewBag.announcement = ann;
            return View("antwrite");
        }

        [HttpPost]
        public ActionResult AnnouncementEdit(int id, string title, string content)
        {
            var ann = new DBC.Announcement(id);
            ann.Title = title;
            ann.Content = content;
            return Redirect("~/admin/Announcement");
        }

        public ActionResult AnnouncementDelete(int id)
        {
            var ann = new DBC.Announcement(id);
            ann.Delete();
            return Redirect("~/admin/Announcement");
        }
     
        #endregion

        #region 文章管理
        public ActionResult Article()
        {
            ViewBag.Title2 = "文章管理";
            var res = DB.SExecuteReader("select id from article");
            var list = new List<DBC.Article>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.Article(id));
            }
            ViewBag.list = list;
            return View();
        }
        //添加
        [HttpGet]
        public ActionResult ArticleAdd()
        {
            ViewBag.Article = true;
            ViewBag.Title2 = "文章管理-添加文章";
            return View("ArticleDetail");
        }
        [HttpPost]
        public ActionResult ArticleAdd(string title,string content,string keywords)
        {
            content = Server.UrlDecode(content);
            DBC.Article.Create(title,content,keywords);
            return Redirect("~/admin/Article");
        }
        
        //修改
        [HttpGet]
        public ActionResult ArticleEdit(int id)
        {
            ViewBag.Title2 = "文章管理-修改文章";
            ViewBag.Article = true;
            var ann = new DBC.Article(id);
            ViewBag.article = ann;
            return View("ArticleDetail");
        }
        [HttpPost]
        public ActionResult ArticleEdit(int id,string title,string content,string keywords)
        {
            content = Server.UrlDecode(content);
            var ann = new DBC.Article(id);
            ann.Title = title;
            ann.Content = content;
            ann.Keywords = keywords;
            return Redirect("~/admin/Article");
        }

        //删除
        public ActionResult ArticleDelete(int id)
        {
            var ann = new DBC.Article(id);
            ann.Delete();
            return Redirect("~/admin/article");
        }
        #endregion

        #region 常见问题管理
        public ActionResult QnA()
        {
            ViewBag.Title2 = "常见问题管理";
            var res = DB.SExecuteReader("select id from qna");
            var list = new List<DBC.QnA>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.QnA(id));
            }
            ViewBag.list = list;
            return View();
        }

        //添加
        [HttpGet]
        public ActionResult QnAAdd()
        {
            ViewBag.QnA = true;
            ViewBag.Title2 = "常见问题管理-添加问题";
            return View("qnadetail");
        }
        [HttpPost]
        public ActionResult QnAAdd(string question,string answer)
        {
            DBC.QnA.Create(question, answer);

            return Redirect("~/admin/QnA");
        }

        //修改
        [HttpGet]
        public ActionResult QnAEdit(int id)
        {
            ViewBag.QnAAdd = true;
            ViewBag.Title2 = "公告管理-修改公告";

            var ann = new DBC.QnA(id);
            ViewBag.qna = ann;
            return View("qnadetail");
        }
        [HttpPost]
        public ActionResult QnAEdit(int id,string question,string answer)
        {
            var ann = new DBC.QnA(id);
            ann.Question = question;
            ann.Answer = answer;
            return Redirect("~/admin/QnA");
        }

        //删除
        public ActionResult QnADelete(int id)
        {
            var ann = new DBC.QnA(id);
            ann.Delete();
            return Redirect("~/admin/QnA");
        }
        #endregion
    }
}
