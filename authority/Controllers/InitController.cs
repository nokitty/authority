using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    [LoginCheck]
    public class InitController : Controller
    {
        //
        // GET: /Init/        
        public ActionResult Index()
        {
            var user = Session["user"] as DBC.User;
            var sql="select id from "+DBTables.Authority;
            var res = DB.SExecuteReader(sql);
            var role = DBC.Role.Create("超级管理员","网站管理员拥有全部权限");
            foreach (var item in res)
            {
                try
                {
                    DB.SExecuteNonQuery("insert into " + DBTables.RoleAuthority + " (roleid,authorityid,value) values (?,?,1)", role.ID, item[0]);
                }
                catch { }
            }

            try
            {
                DB.SExecuteNonQuery("insert into " + DBTables.UserRole + " (userid,roleid) values (?,?)", user.ID, role.ID);
            }
            catch { }


            return Content("OK");
        }

    }
}
