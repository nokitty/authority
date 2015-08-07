using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class QnA : DBC.DBCBase
    {
        string _question;
        public string Question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = (string)SetAttribute("question", value, _question);
            }
        }
        string _answer;
        public string Answer
        {
            get
            {
                return _answer;
            }
            set
            {
                _answer = (string)SetAttribute("answer", value, _answer);
            }
        }
        public DateTime CreateTime { get; set; }

        public QnA(int id)
            : base(DBTables.QnA)
        {
            Initialize("id=?", id);
        }

        protected override void Initialize(string filter, params object[] args)
        {
            var sql = "select id,question,answer,createtime from " + _tableName + " where " + filter;
            var res = DB.SExecuteReader(sql, args);

            if (res.Count == 0)
                throw new Exception("无该记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            Question = (string)row[1];
            Answer = (string)row[2];
            CreateTime = Convert.ToDateTime(row[3]);
        }
        public static QnA Create(string question, string answer)
        {
            var sql = "insert into " + DBTables.QnA + " (question,answer,createtime) values (?,?,?)";
            var id = DB.SInsert(sql, question, answer, DateTime.Now);
            return new QnA(id);
        }
    }
}