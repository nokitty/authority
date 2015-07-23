<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>注册</title>
</head>
<body>
    <div>
        <form action="/account/regist/result" method="post">
            <div>
                <label for="tel">电话号码:</label><input name="tel" id="tel" type="text" /></div>
            <div>
                <label for="password">密码:</label><input name="password" id="password" type="password" /></div>
            <div>
                <label for="name">用户名:</label><input name="name" id="name" type="text" /></div>

            <input type="submit" />
        </form>
    </div>
</body>
</html>
