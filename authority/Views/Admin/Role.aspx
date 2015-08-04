<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" MasterPageFile="~/Views/Share/AdminFrame.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
    <div class="clearfix">
        <a href="/admin/roleadd" class="btn btn-primary pull-right"><span class="glyphicon glyphicon-plus"></span><span>新角色</span></a>
    </div>

    <table class="table">
        <tr>
            <th>角色名</th>
            <th>描述</th>
            <th>操作</th>
        </tr>
        <%foreach (DBC.Role item in ViewBag.list)
          {
        %>
        <tr>
            <td><%=item.Name %></td>
            <td><%=item.Description %></td>
            <td>
                <table>
                    <tr>
                        <td><a href="/admin/roledelete">删除</a></td>
                        <td><a href="/admin/roleedit">修改</a></td>
                    </tr>
                </table>
            </td>
        </tr>
        <%
          } %>
    </table>
</asp:Content>

