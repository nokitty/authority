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

    static void SetRoleAuthority(DBC.Role role,string code,bool value)
    {
        try
        {
            var authoriy = new DBC.Authority(code);
            var sql = "update " + DBTables.RoleAuthority + " set value=? where roleid=? and authorityid=?";
            DB.SExecuteNonQuery(sql, value, role.ID, authoriy.ID);
        }
        catch { }
    }
}