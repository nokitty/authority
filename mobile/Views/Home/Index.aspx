<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/BootstrapFrame.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content  ContentPlaceHolderID="stylesheet" runat="server">
    <link href="../../Css/lawMobile.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <%=Html.Partial("header") %>

        <div class="index_header">
            <img src="/images/guofenchaxun.png" />
        </div>

        <div class="outer-wrap">
            <div class="tips-out-wrap">
                <div class="tips-error" id="tipsFormError"><span class="tips-error-msg"></span></div>
            </div>
            <div class="form-wrap" style="padding-bottom: 26px;">
                <form style="position: relative;" id="form">
                    <ul class="form-iner-wrap" id="searchFormId">
                        <li id="nameWrap" class="input-items">
                            <label class="form-label">姓   名</label>
                            <input id="name" class="form-input" type="text" placeholder="请输入要查询的姓名" data-valida-input="false">
                        </li>
                        <li id="idcardWrap" class="input-items">
                            <label class="form-label">身份证</label>
                            <input id="cardnum" class="form-input" type="text" placeholder="请输入身份证号码前6位" data-valida-input="true">
                            <label class="form-label2">选填</label>
                        </li>
                    </ul>
                </form>
            </div>
            <div class="btn-wrap text-center" style="padding: 0 20px;"><a href="javascript:;" class="btn" style="width: 100%;" id="toSearch" onclick="toSearch()">查询</a></div>
        </div>
    <div class="bottom-nav-wrap">
        <div class="bottom-nav cbody">
            <a href="/report/" class="btn-nav bottom-nav-border-right">曝光老赖</a>
            <a href="/report/list" class="btn-nav">追踪老赖</a>
        </div>
    </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="script" runat="server">
</asp:Content>
