<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/AdminFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <form method="post">
        <div class="form-group">
            <label>角色名称:</label>
            <input name="name" type="text" <%=ViewBag.RoleShow==null?"": "readonly=\"readonly\""%> />
        </div>
        <div class="form-group">
            <label>角色描述:</label>
            <input name="description" type="text"<%=ViewBag.RoleShow==null?"": "readonly=\"readonly\""%> />
        </div>
        <div>
            <div>权限列表</div>
            <table class="table">
                <tr>
                    <th>权限名</th>
                    <th>权限描述</th>
                    <th></th>
                </tr>
                <%foreach (DBC.Authority item in ViewBag.list)
                  {
                %>
                <tr>
                    <td><%=item.Name %></td>
                    <td><%=item.Description %></td>
                    <td>
                        <input type="checkbox" name="<%=item.Code %>"  checked=""/></td>
                </tr>
                <%
                  } %>
            </table>
            <%if (ViewBag.RoleCreate!=null)
              { %>
            <button class="btn btn-primary">创建</button>
            <%} %>
            <%if (ViewBag.RoleEdit!=null)
              { %>
            <button class="btn btn-primary">修改</button>
            <%} %>
        </div>
    </form>
</asp:Content>
