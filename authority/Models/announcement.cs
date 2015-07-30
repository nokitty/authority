using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class Announcement : DBCBase
    {
        string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = (string)SetAttribute("Title", value.Trim(), _title);
            }
        }
        string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content =(string) SetAttribute("Content", value, _content);
            }
        }
        public DateTime CreatedTime { get; set; }

        public Announcement(int id)
            : base(DBTables.Announcement)
        {

        }

        protected override void Initialize(string filter, params object[] agrs)
        {
            var sql = "select id,title,content,createtime from " + _tableName + " where " + filter;
            var res = DB.SExecuteReader(sql);
            if (res.Count == 0)
                throw new Exception("无该记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            _title = (string)row[1];
            _content = (string)row[2];
            CreatedTime = Convert.ToDateTime(row[3]);
        }

        public static Announcement Create(string title,string content)
        {
            var sql="insert into "+_tableName+" (title,content,createtime) values (?,?,?)";
            var id = DB.SInsert(sql, title, content,DateTime.Now);
            return new Announcement(id);
        }
        
    }
   
}