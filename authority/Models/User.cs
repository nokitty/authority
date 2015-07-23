using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBC
{
    public class User
    {
        public const string TableName = "user";
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public User(int id)
        {
            var sql = "select id,name,tel,password from " + TableName + " where id=?";
            var res = DB.SExecuteReader(sql, id);

            if (res.Count == 0)
                throw new Exception("没有找到记录");

            var row = res[0];
            ID = Convert.ToInt32(row[0]);
            Name = (string)row[1];
            Tel = (string)row[2];
            Password = (string)row[3];
        }
        public static User Create(string tel, string password,string name)
        {
            try
            {
                var sql="insert into "+TableName+" (tel,password,name) values (?,?,?)";
                var userid = DB.SInsert(sql, tel, password,name);
                return new User(userid);
            }
            catch
            {
                throw new Exception("已经创建过用户");
            }
        }
        public static User Login(string tel,string password,bool remember=true)
        {
            var sql = "select id from " + TableName + " where tel=? and password=?";
            var res = DB.SExecuteScalar(sql, tel, password);

            try
            {
                var id = Convert.ToInt32(res);
                var user = new User(id);

                var cookie = new HttpCookie("login");
                cookie.Value = Guid.NewGuid().ToString("b");
                if(remember==true)
                {
                    cookie.Expires = DateTime.Now.AddDays(15);
                    DB.SInsert("insert into user_login_cookie (userid,value) values (?,?)", user.ID, cookie.Value);
                }

                HttpContext.Current.Response.SetCookie(cookie);

                return user;
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}