using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//权限集
static public class AuthoritySet
{
    public static  UserManageModule User = new UserManageModule();
    public static  AuthorityManageModule Authority = new AuthorityManageModule();
    //用户管理权限
    public class UserManageModule
    {
        public  DBC.Authority CanAccess = new DBC.Authority("User.CanAccess");
        public  DBC.Authority CanCreate =new DBC.Authority( "User.CanCreate");
        public  DBC.Authority CanDelete =new DBC.Authority( "User.CanDelete");
    }
    //权限管理权限
    public class AuthorityManageModule
    {
        public  DBC.Authority CanModify =new DBC.Authority( "Authority.CanModify");
    }
}

