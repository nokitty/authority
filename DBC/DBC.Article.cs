using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class Article : DBCBase
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
                _title = (string)SetAttribute("title", value, _title);
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
                _content = (string)SetAttribute("content", value, _content);
            }
        }

        string _keywords;
        public string Keywords
        {
            get
            {
                return _keywords;
            }
            set
            {
                _content = (string)SetAttribute("keywords", value, _keywords);
            }
        }
        public DateTime CreateTime { get; set; }

        public Article(int id)
            : base(DBTables.Article)
        {
            Initialize("id=?", id);
        }

        protected override void Initialize(string filter, params object[] args)
        {
            var sql = "select id,title,content,keywords,createtime from " + _tableName + " where " + filter;
            var res = DB.SExecuteReader(sql, args);

            if (res.Count == 0)
                throw new Exception("无该记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            _title = (string)row[1];
            _content = (string)row[2];
            _keywords = (string)row[3];
            CreateTime = Convert.ToDateTime(row[4]);
        }

        public static Article Create(string title, string content, string keywords)
        {
            var sql = "insert into " + _tableName + " (title,content,keywords,createtime) values (?,?,?,?)";
            var id = DB.SInsert(sql, title, content, keywords, DateTime.Now);

            return new Article(id);
        }
    }
}