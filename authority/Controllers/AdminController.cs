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
                    var code=(string)item[0];
                    var value= Request.Form[code]
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
    }
}
