<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>登录</title>
</head>
<body>
    <div>
        <form action="/account/login/result" method="post">
            <div>
                <label for="tel">电话号码:</label><input name="tel" id="tel" type="text" />
            </div>
            <div>
                <label for="password">密码:</label><input name="password" id="password" type="password" />
            </div>
                        <div>
                <input name="remember" id="remember" type="checkbox" /><label for="remember">记住我的登录状态</label>
            </div>
            <input type="submit" />
        </form>
    </div>
</body>
</html>
