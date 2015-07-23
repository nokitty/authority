using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class Authority
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string  Code { get; set; }
        public string Description { get; set; }

        public Authority(int id)
        {
            Initialize("id=?", id);
        }
        public Authority(string code)
        {
            Initialize("code=?", code);
        }

        void Initialize(string filter,params object[] args)
        {
            var sql = "select id,name,description,code from " + DBTables.Authority + " where " + filter;
            var res = DB.SExecuteReader(sql, args);

            if (res.Count == 0)
                throw new Exception("没有找到该记录");

            var row=res[0];
            ID = Convert.ToInt32(row[0]);
            Name = (string)row[1];
            Description = (string)row[2];
            Code = (string)row[3];
        }
    }
}