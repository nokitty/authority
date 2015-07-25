using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Role(int id)
        {
            Initialize("id=?", id);
        }

        public Role(string name)
        {
            Initialize("name=?", name);
        }

        public void Initialize(string filter,params object[] args)
        {
            var sql = "select id ,name,description from " + DBTables.Role + " where "+filter;
            var res = DB.SExecuteReader(sql, args);

            if (res.Count == 0)
                throw new Exception("没找到记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            Name = (string)row[1];
            Description = (string)row[2];
        }

        public static Role Create(string name,string description)
        {
            try
            {
                return new Role(name);
            }
            catch
            {
                var id = DB.SInsert("insert into " + DBTables.Role + " (name,description) values (?,?)", name,description);
                return new Role(name);
            }
        }
    }
}