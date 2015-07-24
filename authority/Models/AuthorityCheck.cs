using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

    public class AuthorityCheck:AuthorizeAttribute
    {
        string[] _codes;

        public AuthorityCheck(params string[] codes)
        {
            _codes = codes;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = httpContext.Session["user"] as DBC.User;
            return AuthorityHelper.Check(user, _codes);
        }

        protected override void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext)
        {
            var result = new ContentResult();
            result.Content = "无操作权限";
            filterContext.Result = result;
        }
    }

    public class LoginCheck : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["user"] == null)
                return false;
            else
                return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var result = new ContentResult();
            result.Content = "请先登录";
            filterContext.Result = result;
        }
    }