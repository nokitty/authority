<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<div class="header clearfix">
    <%if (ViewData["showhome"] != null)
      { %>
    <div class="home pull-left"><span class="glyphicon glyphicon-home icon"></span></div>
    <%} %>
    <div class="menu pull-right"><span class="glyphicon glyphicon-menu-hamburger icon"></span></div>
    <div class="title text-center">标题</div>
</div>
