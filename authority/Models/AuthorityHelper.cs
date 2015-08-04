using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static public class AuthorityHelper
{
    static public bool Check(DBC.Role role,params string[] codes)
    {
        var res = true;
        foreach (string code in codes)
        {
            try
            {
                var authority = new DBC.Authority(code);
                var sql = "select value from " + DBTables.RoleAuthority + " where roleid=? and authorityid=?";
                var res11 = DB.SExecuteScalar(sql, role.ID, authority.ID);

                res &= Convert.ToBoolean(res11);
                if (res == false)
                    break;
            }
            catch { }
        }
        return res;
    }

    static public bool Check(DBC.User user,params string[] codes)
    {
        if (user == null)
            return false;

        var sql = "select roleid from " + DBTables.UserRole + " where userid=?";
        var res = DB.SExecuteReader(sql, user.ID);
        var b = false;
        foreach (var item in res)
        {
            var role = new DBC.Role(Convert.ToInt32(item[0]));
            b |= Check(role, codes);
            if (b)
                break;
        }
        return b;
    }

    //权限列表
    public static List<DBC.Authority> AuthorityList { set; get; }
    //角色列表
    public static List<DBC.Role> RoleList { set; get; }

    static AuthorityHelper()
    {
        //获取权限列表
        {
            var sql = "select id from " + DBTables.Authority;
            var res = DB.SExecuteReader(sql);

            AuthorityList = new List<DBC.Authority>();
            foreach (var item in res)
            {
                var authorityId = Convert.ToInt32(item[0]);
                var authority = new DBC.Authority(authorityId);
                AuthorityList.Add(authority);
            }
        }
        //获取角色列表
        {
            var sql = "select id from " + DBTables.Role;
            var res = DB.SExecuteReader(sql);

            RoleList = new List<DBC.Role>();
            foreach (var item in res)
            {
                var roleId = Convert.ToInt32(item[0]);
                var role = new DBC.Role(roleId);
                RoleList.Add(role);
            }
        }
    }
}