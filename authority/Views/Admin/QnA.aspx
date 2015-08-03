<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/AdminFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div class="clearfix">
        <a href="/admin/qnaadd" class="btn btn-primary pull-right"><span class="glyphicon glyphicon-plus"></span><span>新问题</span></a>
    </div>
     <table class="table">
        <tr>
            <th>问题</th>
            <th>答复</th>
            <th>操作</th>
        </tr>
        <%foreach (DBC.QnA item in ViewBag.list)
          {
        %>
        <tr>
            <td><%=item.Question %></td>
            <td><%=item.Answer %></td>
            <td>
                <table>
                    <tr>
                        <td><a href="/admin/qnadelete?id=<%=item.ID %>">删除</a></td>
                        <td><a href="/admin/qnaedit?id=<%=item.ID %>">修改</a></td>
                    </tr>
                </table>
            </td>
        </tr>
        <%
          } %>
    </table>


</asp:Content>
