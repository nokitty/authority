<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/BootstrapFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">

    <div class="container">
        <form style="margin-top: 50px" method="post">
            <%if (ViewBag.loginFail == true)
              { %>
            <div class="alert alert-danger">帐号或密码错误,请重新输入</div>
            <%} %>
            <div class="panel panel-primary">
                <div class="panel-heading">登录</div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>用户名:</label>
                        <input type="text" class="form-control" name="tel" />
                    </div>
                    <div class="form-group">
                        <label>密码:</label>
                        <input type="password" class="form-control" name="password" />
                    </div>
                    <div class="form-group">
                        <input name="remember" type="checkbox" checked="checked"/>
                        <label>记住我的登录状态</label>
                    </div>
                    <span>我还没有帐号 </span><a href="/signup">快速注册</a>
                </div>
                <div class="panel-footer">
                    <input type="submit" class="form-control center-block" value="登录" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>
