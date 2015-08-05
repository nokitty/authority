<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/AdminFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <table class="table">
        <tr>
            <th>被举报人</th>
            <th>欠款金额</th>
            <th>审核状况</th>
            <th>操作</th>
        </tr>
        <%foreach (DBC.ReportedPerson item in ViewBag.list)
          {
              var p = new DBC.Person(item.PersonId);
        %>
        <tr>
            <td><%=p.Name%></td>
            <td><%=item.Arrears %></td>
            <td>
                <%switch ((ReportedPersonCheckStates)item.CheckState)
                  {
                      case ReportedPersonCheckStates.NotCheck:
                          Response.Write("未审核");
                          break;
                      case ReportedPersonCheckStates.NotPass:
                          Response.Write("审核不通过");
                          break;
                      case ReportedPersonCheckStates.Pass:
                          Response.Write("审核通过");
                          break;
                      default:
                          break;
                  } %>
            </td>
            <td>
                <table>
                    <tr>
                        <td><a href="/Admin/reportdelete?id=<%=item.ID %>">删除</a></td>
                        <td><a href="/Admin/reportedit?id=<%=item.ID %>">修改</a></td>
                    </tr>
                </table>
            </td>
        </tr>
        <%
          } %>
    </table>

</asp:Content>


