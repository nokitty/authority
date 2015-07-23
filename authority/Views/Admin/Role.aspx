<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>"  MasterPageFile="~/Views/Share/BootstrapFrame.Master"%>

<asp:Content runat="server" ContentPlaceHolderID="body">
<div class="container">
    <div class="row">
        <div class="col-lg-6 col-md-6 col-sm-6"><h3>角色管理</h3></div>
        <div class="col-lg-6 col-md-6 col-sm-6"><a class="btn btn-primary pull-right" href="/admin/role/add"><span class="glyphicon glyphicon-plus" ></span><span>添加新角色</span></a></div>
    </div>
    <table class="table table-bordered">
        <tr>
            <th>
               角色名
            </th>
            <th>
                角色描述
            </th>
            <th>
            </th>
        </tr>

    </table>
</div>
</asp:Content>

