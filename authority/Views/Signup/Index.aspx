<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/BootstrapFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">

    <div class="container">
        <form style="margin-top: 50px" method="post">
            <div class="alert alert-danger collapse">帐号或密码错误,请重新输入</div>
            <div class="panel panel-primary">
                <div class="panel-heading">注册</div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>手机号码:</label>
                        <input type="text" class="form-control" name="tel" />
                    </div>
                    <div class="form-group">
                        <label>密码:</label>
                        <input type="password" class="form-control" name="password" />
                    </div>
                    <div class="form-group">
                        <label>手机验证码:</label>
                        <div class="row">
                            <div class="col-lg-9 col-md-9 col-sm-9"><input type="text" class="form-control" name="captcha" /></div>
                            <div class="col-lg-3 col-md-3 col-sm-3"><div class="btn btn-primary btn-block">获取验证码</div></div>
                        </div>
                        
                    </div>
                    <div class="form-group">
                        <input type="checkbox" checked="checked" />
                        <a href="#">我同意"查老赖"服务条款</a>
                    </div>
                </div>
                <div class="panel-footer">
                    <input type="submit" class="form-control center-block" value="注册" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="script" runat="server">
</asp:Content>
