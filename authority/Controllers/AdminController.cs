﻿using System;
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

            ViewBag.roleList = list;
            return View();
        }

        //添加
        [HttpGet]
        public ActionResult RoleAdd()
        {
            ViewBag.RoleCreate = true;
            ViewBag.Title2 = "角色管理-添加新角色";

            var sql = "select id from " + DBTables.Authority;
            var res = DB.SExecuteReader(sql);

            var authorityList = new List<DBC.Authority>();
            foreach (var item in res)
            {
                //获取权限名
                var id = Convert.ToInt32(item[0]);
                authorityList.Add(new DBC.Authority(id));
            }

            ViewBag.athorityList = authorityList;
            return View("roledetail");
        }
        [HttpPost]
        public ActionResult RoleAdd(FormCollection collection)
        {
            var name = Request.Form["name"];
            var description = Request.Form["description"];
            var role = DBC.Role.Create(name, description);

            var sql = "select code from " + DBTables.Authority;
            var res = DB.SExecuteReader(sql);
            foreach (var item in res)
            {
                var code = (string)item[0];
                role.SetAuthority();
                //var value = Request.Form[code];
            }

            return View();
        }

        //编辑
        [HttpGet]
        public ActionResult RoleEdit(int id)
        {
            ViewBag.Title2 = "权限管理--修改";
            ViewBag.RoleEdit = true;

            var role = new DBC.Role(id);

            var sql = "select id from " + DBTables.Authority;
            var res = DB.SExecuteReader(sql);

            var authorityList = new List<DBC.Authority>();
            foreach (var item in res)
            {
                //获取权限名
                var authorityId = Convert.ToInt32(item[0]);
               var authority=new DBC.Authority(authorityId);
                authorityList.Add(authority);

                //获取权限值
                var res1 = DB.SExecuteScalar("select value from " + DBTables.RoleAuthority + " where authorityid=? and roleid=?", authorityId, role.ID);
                ViewData[]
            }

            ViewBag.athorityList = authorityList;    

            return View("roledetail");
        }


        [HttpPost]
        public ActionResult RoleEdit()
        {

            return View("roledetail");
        }

        public ActionResult RoleDelete(int id)
        {
            return View();
        }
        #endregion

        #region 用户管理
        //显示用户列表，显示用户所属角色
        public ActionResult Users()
        {
            //to do here
            return View();
        }
        //修改用户所属角色，其他不能修改
        [HttpGet]
        public ActionResult UsersEdit(int id)
        {
            //to do here
            return View();
        }
        [HttpPost]
        public ActionResult UsersEdit()
        {
            //to do here
            return View();
        }

        #endregion

        #region 举报管理
        public ActionResult Report()
        {
            return View();
        }

        //修改（只能修改审核状态，其他信息不能修改）
        [HttpGet]
        public ActionResult ReportEdit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReportEdit(int id, ReportedPersonCheckStates state)
        {
            return View();
        }

        //删除
        public ActionResult ReportDelete(int id)
        {
            return View();
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
        public ActionResult ArticleAdd(string title, string content, string keywords)
        {
            content = Server.UrlDecode(content);
            DBC.Article.Create(title, content, keywords);
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
        public ActionResult QnAAdd(string question, string answer)
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
        public ActionResult QnAEdit(int id, string question, string answer)
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
