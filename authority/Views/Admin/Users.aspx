<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/AdminFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <table class="table">
        <tr>
            <th>手机号码</th>
            <th>所属角色</th>
            <th>操作</th>
        </tr>
        <%foreach (DBC.User item in ViewBag.userList)
          {
        %>
        <tr>
            <td><%=item.Tel %></td>
            <td>
                <%
              var roles = item.GetRoles();
              if (roles.Count == 0)
              { 
                %>
              无
              <%
              }
              else
              {
                  var str = "";
                  foreach (var role in roles)
                  {
                      str += role.Name + " ";
                  }
              %>
                <%=str %>
                <%
              }
                %>
            </td>
            <td>
                <table>
                    <tr>
                        <td><a href="/admin/usersedit?id=<%=item.ID %>">修改所属角色</a></td>
                    </tr>
                </table>
            </td>
        </tr>
        <%
          } %>
    </table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="script" runat="server">
</asp:Content>
