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
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="script" runat="server">
</asp:Content>
