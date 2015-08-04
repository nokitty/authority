using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class Role : DBCBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Role(int id)
            : base(DBTables.Role)
        {
            Initialize("id=?", id);
        }

        public Role(string name)
            : base(DBTables.Role)
        {
            Initialize("name=?", name);
        }

        public void SetAuthority(string code, bool value)
        {
            var authority = new DBC.Authority(code);
            var sql1 = "delete from " + DBTables.RoleAuthority + " where roleid=? and authorityid=?";
            DB.SExecuteNonQuery(sql1, ID, authority.ID);

            var sql2 = "insert into " + DBTables.RoleAuthority + " (roleid,authorityid,value) values (?,?,?)";
            DB.SExecuteNonQuery(sql2, ID, authority.ID, value);
        }

        override protected void Initialize(string filter, params object[] args)
        {
            var sql = "select id ,name,description from " + DBTables.Role + " where " + filter;
            var res = DB.SExecuteReader(sql, args);

            if (res.Count == 0)
                throw new Exception("没找到记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            Name = (string)row[1];
            Description = (string)row[2];
        }

        public static Role Create(string name, string description)
        {
            try
            {
                return new Role(name);
            }
            catch
            {
                //插入新的行
                var id = DB.SInsert("insert into " + DBTables.Role + " (name,description) values (?,?)", name, description);
                return new Role(name);
            }
        }

        public override void Delete()
        {
            //删除角色权限列表中的记录
            var sql = "delete from " + DBTables.RoleAuthority + " where roleid=?";
            DB.SExecuteNonQuery(sql, ID);

            //调用基类删除自身
            base.Delete();
        }

        public void AddUser(DBC.User user)
        {
            var sql = "insert ignore into " + DBTables.UserRole + " (userid,roleid) values (?,?)";
            DB.SExecuteNonQuery(sql, user.ID, ID);
        }

        public void RemoveUser(DBC.User user)
        {
            var sql = "delete from " + DBTables.UserRole + " where userid=? and roleid=? ";
            DB.SExecuteNonQuery(sql, user.ID, ID);
        }
    }
}