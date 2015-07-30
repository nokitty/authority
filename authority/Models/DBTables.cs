using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

static public class DBTables
{
    public static string RoleAuthority = WebConfigurationManager.AppSettings["DBTables.RoleAuthority"];
    public static string UserRole = WebConfigurationManager.AppSettings["DBTables.UserRole"];
    public static string Role = WebConfigurationManager.AppSettings["DBTables.Role"];
    public static string Authority = WebConfigurationManager.AppSettings["DBTables.Authority"];
    public static string User = WebConfigurationManager.AppSettings["DBTables.User"];
    public static string UserLoginCookie = WebConfigurationManager.AppSettings["DBTables.UserLoginCookie"];
    public static string Announcement = WebConfigurationManager.AppSettings["DBTables.Announcement"];
}