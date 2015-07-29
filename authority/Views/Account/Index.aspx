<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/BootstrapFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <%var user = Session["user"] as DBC.User;%>
    <div class="container">
        <div class="clearfix">
                        <%if (AuthorityHelper.Check(user, "Admin.Access"))
              { %>
            <a href="/admin" class="pull-right">后台管理</a>
            <%} %>
            <a href="/logout" class="pull-right">退出</a>
            <span class="pull-right"><%=user.Name %></span> 

        </div>
        <h2>这里是用户信息页</h2>

        <div class="row">
            <div class="col-lg-2">
                <div class="list-group">
                    <a class="list-group-item active">基本信息</a>
                    <a class="list-group-item">举报管理</a>
                    <a class="list-group-item">悬赏管理</a>
                </div>
            </div>
            <div class="col-lg-10">
                <div class="panel panel-default">
                    <div class="panel-body">
                        <div>这里是具体的用户信息</div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="script" runat="server">
</asp:Content>
