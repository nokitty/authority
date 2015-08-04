using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    [LoginCheck(Order = 0)]
    [AuthorityCheck("Admin.Access", Order = 1)]
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
            var res = DB.SExecuteReader("select id from " + DBTables.Role);
            var list = new List<DBC.Role>();
            foreach (var item in res)
            {
                var id = Convert.ToInt32(item[0]);
                list.Add(new DBC.Role(id));
            }

            ViewBag.roleList = list;
            return View();
        }

        //添加
        [AuthorityCheck("Role.Access")]
        [HttpGet]
        public ActionResult RoleAdd()
        {
            ViewBag.RoleCreate = true;
            ViewBag.Title2 = "角色管理-添加新角色";

            ViewBag.athorityList = AuthorityHelper.AuthorityList;
            return View("roledetail");
        }
        [AuthorityCheck("Role.Access")]
        [HttpPost]
        public ActionResult RoleAdd(string name,string description)
        {
            var role = DBC.Role.Create(name, description);
            foreach (var item in AuthorityHelper.AuthorityList)
            {
                var code = item.Code;
                var value = string.IsNullOrWhiteSpace(Request.Form[code]) ? true : false;
                role.SetAuthority(code, value);
            }
            return Redirect("~/admin/role");
        }

        //编辑
        [AuthorityCheck("Role.Access")]
        [HttpGet]
        public ActionResult RoleEdit(int id)
        {
            ViewBag.Title2 = "权限管理--修改";
            ViewBag.RoleEdit = true;

            var role = new DBC.Role(id);
            ViewBag.role = role;
            ViewBag.athorityList = AuthorityHelper.AuthorityList;

            return View("roledetail");
        }

        [AuthorityCheck("Role.Access")]
        [HttpPost]
        public ActionResult RoleEdit(int id, FormCollection form)
        {
            var role = new DBC.Role(id);
            foreach (var item in AuthorityHelper.AuthorityList)
            {
                var value = string.IsNullOrWhiteSpace(form[item.Code]) ? false : true;
                role.SetAuthority(item.Code, value);
            }
            return Redirect("~/admin/role");
        }
        //删除
        [AuthorityCheck("Role.Access")]
        public ActionResult RoleDelete(int id)
        {
            var role = new DBC.Role(id);
            role.Delete();
            return Redirect("~/admin/role");
        }
        #endregion

        #region 用户管理
        //显示用户列表，显示用户所属角色
        [AuthorityCheck("User.Access")]
        public ActionResult Users()
        {
            ViewBag.Title2 = "用户管理";
            var list = new List<DBC.User>();
            var sql="select id from "+DBTables.User;
            var res = DB.SExecuteReader(sql);
            foreach (var item in res)
            {
                var user = new DBC.User(Convert.ToInt32(item[0]));
                list.Add(user);
            }

            ViewBag.userList = list;
            return View();
        }

        //修改用户所属角色，其他不能修改
        [AuthorityCheck("User.Access")]
        [HttpGet]
        public ActionResult UsersEdit(int id)
        {
            var user = new DBC.User(id);
            ViewBag.user = user;
            return View("usersdetail");
        }
        [AuthorityCheck("User.Access")]
        [HttpPost]
        public ActionResult UsersEdit(int id,FormCollection form)
        {
            var user = new DBC.User(id);
            foreach (var role in AuthorityHelper.RoleList)
            {
                var value = string.IsNullOrWhiteSpace(form["role_" + role.ID]);
                if(value==false)
                {
                    //添加
                    var sql = "insert ignore into " + DBTables.UserRole + " (userid,roleid) values (?,?)";
                    DB.SExecuteNonQuery(sql, user.ID, role.ID);
                }
                else
                {
                    //删除
                    var sql = "delete from " + DBTables.UserRole + " where userid=? and roleid=? ";
                    DB.SExecuteNonQuery(sql, user.ID, role.ID);
                }
            }
            return Redirect("~/admin/users");
        }

        #endregion

        #region 举报管理
        [AuthorityCheck("Report.Access")]
        public ActionResult Report()
        {
            return View();
        }

        //修改（只能修改审核状态，其他信息不能修改）
        [AuthorityCheck("Report.Access")]
        [HttpGet]
        public ActionResult ReportEdit(int id)
        {
            return View();
        }
        [AuthorityCheck("Report.Access")]
        [HttpPost]
        public ActionResult ReportEdit(int id, ReportedPersonCheckStates state)
        {
            return View();
        }

        //删除
        [AuthorityCheck("Report.Access")]
        public ActionResult ReportDelete(int id)
        {
            return View();
        }
        #endregion

        #region 公告管理
        [AuthorityCheck("Announcement.Access")]
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

        //添加
        [AuthorityCheck("Announcement.Access")]
        [HttpGet]
        public ActionResult AnnouncementAdd()
        {
            ViewBag.AnnouncementAdd = true;
            ViewBag.Title2 = "公告管理-添加公告";

            return View("antwrite");
        }
        [AuthorityCheck("Announcement.Access")]
        [HttpPost]
        public ActionResult AnnouncementAdd(string title, string content)
        {
            DBC.Announcement.Create(title, content);

            return Redirect("~/admin/Announcement");
        }

        //修改
        [AuthorityCheck("Announcement.Access")]
        [HttpGet]
        public ActionResult AnnouncementEdit(int id)
        {
            ViewBag.AnnouncementAdd = true;
            ViewBag.Title2 = "公告管理-修改公告";

            var ann = new DBC.Announcement(id);
            ViewBag.announcement = ann;
            return View("antwrite");
        }
        [AuthorityCheck("Announcement.Access")]
        [HttpPost]
        public ActionResult AnnouncementEdit(int id, string title, string content)
        {
            var ann = new DBC.Announcement(id);
            ann.Title = title;
            ann.Content = content;
            return Redirect("~/admin/Announcement");
        }

        //删除
        [AuthorityCheck("Announcement.Access")]
        public ActionResult AnnouncementDelete(int id)
        {
            var ann = new DBC.Announcement(id);
            ann.Delete();
            return Redirect("~/admin/Announcement");
        }

        #endregion

        #region 文章管理
        [AuthorityCheck("Article.Access")]
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
        [AuthorityCheck("Article.Access")]
        [HttpGet]
        public ActionResult ArticleAdd()
        {
            ViewBag.Article = true;
            ViewBag.Title2 = "文章管理-添加文章";
            return View("ArticleDetail");
        }
        [AuthorityCheck("Article.Access")]
        [HttpPost]
        public ActionResult ArticleAdd(string title, string content, string keywords)
        {
            content = Server.UrlDecode(content);
            DBC.Article.Create(title, content, keywords);
            return Redirect("~/admin/Article");
        }

        //修改
        [AuthorityCheck("Article.Access")]
        [HttpGet]
        public ActionResult ArticleEdit(int id)
        {
            ViewBag.Title2 = "文章管理-修改文章";
            ViewBag.Article = true;
            var ann = new DBC.Article(id);
            ViewBag.article = ann;
            return View("ArticleDetail");
        }
        [AuthorityCheck("Article.Access")]
        [HttpPost]
        public ActionResult ArticleEdit(int id, string title, string content, string keywords)
        {
            content = Server.UrlDecode(content);
            var ann = new DBC.Article(id);
            ann.Title = title;
            ann.Content = content;
            ann.Keywords = keywords;
            return Redirect("~/admin/Article");
        }

        //删除
        [AuthorityCheck("Article.Access")]
        public ActionResult ArticleDelete(int id)
        {
            var ann = new DBC.Article(id);
            ann.Delete();
            return Redirect("~/admin/article");
        }
        #endregion

        #region 常见问题管理
        [AuthorityCheck("QnA.Access")]
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
        [AuthorityCheck("QnA.Access")]
        [HttpGet]
        public ActionResult QnAAdd()
        {
            ViewBag.QnA = true;
            ViewBag.Title2 = "常见问题管理-添加问题";
            return View("qnadetail");
        }
        [AuthorityCheck("QnA.Access")]
        [HttpPost]
        public ActionResult QnAAdd(string question, string answer)
        {
            DBC.QnA.Create(question, answer);

            return Redirect("~/admin/QnA");
        }

        //修改
        [AuthorityCheck("QnA.Access")]
        [HttpGet]
        public ActionResult QnAEdit(int id)
        {
            ViewBag.QnAAdd = true;
            ViewBag.Title2 = "公告管理-修改公告";

            var ann = new DBC.QnA(id);
            ViewBag.qna = ann;
            return View("qnadetail");
        }
        [AuthorityCheck("QnA.Access")]
        [HttpPost]
        public ActionResult QnAEdit(int id, string question, string answer)
        {
            var ann = new DBC.QnA(id);
            ann.Question = question;
            ann.Answer = answer;
            return Redirect("~/admin/QnA");
        }

        //删除
        [AuthorityCheck("QnA.Access")]
        public ActionResult QnADelete(int id)
        {
            var ann = new DBC.QnA(id);
            ann.Delete();
            return Redirect("~/admin/QnA");
        }
        #endregion
    }
}
