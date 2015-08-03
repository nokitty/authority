<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/AdminFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
<div class="clearfix">
        <a href="/admin/articleadd" class="btn btn-primary pull-right"><span class="glyphicon glyphicon-plus"></span><span>新文章</span></a>
    </div>
    <table class="table">
        <tr>
            <th>标　题</th>
            <th>内　容</th>
            <th>关键字</th>
            <th>操作</th>
        </tr>
        <%foreach (DBC.Article item in ViewBag.list)
          {
        %>
        <tr>
            <td><%=item.Title %></td>
            <td><%=item.Content %></td>
            <td><%=item.Keywords %></td>
            <td>
                <table>
                    <tr>
                        <td><a href="/admin/articledelete?id=<%=item.ID %>">删除</a></td>
                        <td><a href="/admin/articleedit?id=<%=item.ID %>">修改</a></td>
                    </tr>
                </table>
            </td>
        </tr>
        <%
          } %>
    </table>
</asp:Content>
