using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class Role
    {
        public static  string TableName = "role";
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Role(int id)
        {
            var sql = "select id ,name,description from " + DBTables.Role + " where id=?";
            var res = DB.SExecuteReader(sql, id);

            if (res.Count == 0)
                throw new Exception("没找到记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            Name = (string)row[1];
            Description = (string)row[2];
        }

        public static Role Create(Role role)
        {
            return role;
        }
    }
}