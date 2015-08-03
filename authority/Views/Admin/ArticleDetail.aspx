<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/AdminFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
 <%var ann = ViewBag.article as DBC.Article; %> 
    <form method="post">
        <div class="form-group">
            <label>文章标题:</label>
            <input name="title" style="width: 100%;" type="text" value="<%=ann==null?"":ann.Title %>" />
        </div>
        <div class="form-group">
            <label>文章内容:</label>
            <input name="content" style="width: 100%; height: 250px;" type="text" value="<%=ann==null?"":ann.Content %>" />
        </div>
         <div class="form-group">
            <label>　关键字:</label>
            <input name="keywords" style="width:30%;" type="text" value="<%=ann==null?"":ann.Keywords %>" />
        </div>
        <button class="btn btn-primary">提交</button>
    </form>
</asp:Content>
