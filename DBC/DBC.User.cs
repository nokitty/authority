using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class User:DBCBase
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }

        public User(int id):base(DBTables.User)
        {
            Initialize("id=?", id);
        }
        public static User Create(string tel, string password,string name)
        {
            try
            {
                var sql="insert into "+DBTables.User+" (tel,password,name) values (?,?,?)";
                var userid = DB.SInsert(sql, tel, password,name);
                return new User(userid);
            }
            catch
            {
                throw new Exception("已经创建过用户");
            }
        }
        protected override void Initialize(string filter, params object[] args)
        {
            var sql = "select id,name,tel,password from " + DBTables.User + " where "+filter;
            var res = DB.SExecuteReader(sql, args);

            if (res.Count == 0)
                throw new Exception("没有找到记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            Name = (string)row[1];
            Tel = (string)row[2];
            Password = (string)row[3];
        }
        public List<DBC.Role> GetRoles()
        {
            var list = new List<DBC.Role>();

            var sql = "select roleid from " + DBTables.UserRole + " where userid=?";
            var res = DB.SExecuteReader(sql, ID);

            foreach (var item in res)
            {
                try
                {
                    var auth = new DBC.Role(Convert.ToInt32(item[0]));
                    list.Add(auth);
                }
                catch { }
            }
            return list;
        }
    }
}