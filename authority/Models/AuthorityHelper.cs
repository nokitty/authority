using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static public class AuthorityHelper
{

    static public bool Check(DBC.Role role,DBC.Authority authority)
    {
        var sql = "select value from " + DBTables.RoleAuthority + " where roleid=? and authorityid=?";
        var res = DB.SExecuteScalar(sql,role.ID,authority.ID);
        return Convert.ToBoolean(res);
    }

    static public bool Check(DBC.User user,DBC.Authority authority)
    {
        var sql = "select roleid from " + DBTables.UserRole + " where userid=?";
        var res = DB.SExecuteReader(sql, user.ID);
        var b = false;
        foreach (var item in res)
        {
            var role = new DBC.Role(Convert.ToInt32(item[0]));
            b |= Check(role, authority);
            if (b)
                break;
        }
        return b;
    }

    static void Set(DBC.User user, DBC.Role role,DBC.Authority authority,bool value)
    {
        if (Check(user, AuthoritySet.Authority.CanModify)==false)
            throw new Exception("权限不足");

        var sql = "update " + DBTables.RoleAuthority + " set value=? where roleid=? and authorityid=?";
        DB.SExecuteNonQuery(sql, value, role.ID, authority.ID);
    }
}