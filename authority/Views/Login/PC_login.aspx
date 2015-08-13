<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.idCard/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.idCard/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>登陆</title>
<link rel="stylesheet" type="text/css" href="/css/base.css" />

<link rel="stylesheet" type="text/css" href="/css/index.css" />

<link rel="stylesheet" type="text/css" href="/css/style.css" />

<script type="text/javascript" src="/js/jquery.min.js"></script>

<script type="text/javascript" src="/js/jquery-1.10.2.min.js"></script>

<script type="text/javascript" src="/js/common.js"></script>

<script type="text/javascript" src="/js/jquery.cookie.js"></script>

<script type="text/javascript" src="/js/law.js"></script>

</head>

<body>

<div class="header">

    <div class="header_tittle">
    
        <div class="header_Nav">
        
            <img src="/images/logo2.png" />
            
            <ul>
            
                <li class="cur"><a href="/">首页</a></li>
                
                <li><a>信用查询</a></li>
                
                <li><a>举报老赖</a></li>
                
                <li><a>悬赏查询</a></li>
                
                <li><a>关于我们</a></li>
                
            </ul>
            
            <div class="login">
                
                <a href="/login">登陆</a>/
                
                <a href="/signup">注册</a>
            
            </div>
        
        </div>
    
    </div>
    
    <div class="header_content">
    
    <div class="header_login">
        <div class="logwf_right">
            <div class="logrg_bk">
            <img src="/images/yongh1_tb.gif" alt="" style="margin:0px;"> 用户名：
            <p><input name="Text1" id="userName" type="text" class="log_input" onblur="if(this.value==''){this.value='';}" onfocus="if(this.value=='') {this.value='';this.style.color = '#000'}" value="" style="color: rgb(0, 0, 0);"></p>
            <img src="/images/yongh2_tb.gif" alt="" style="margin:0px;"> 密　码：
            <p><input name="txtPassword" id="txtPassword" type="text" class="log_input" value="">
            <input name="userPassword" id="userPassword" type="password" class="log_input" style="display:none"></p>
            &nbsp; 验证码：<input name="validateCode" id="validateCode" maxlength="4" onkeyup="value=value.replace(/[^\d]/g,'')" class="log_input1" type="text"> &nbsp;
                 <img id="imgCode" src="/images/CheckCode.gif" class="vMiddle" alt="看不清？点击换一张。" style="cursor:pointer"><br>
            <input type="image" id="btnLogin" src="/images/log_denglu.gif" style="width:222px; height:40px; margin-top:15px;">
            <p class="wyzc_tp"><a href="Safety/GetPass1.aspx">忘记密码</a>&nbsp; | <a href="/signup">立即注册</a></p>
            
            
            
            
            </div>
        </div>
        </div>
    </div>
</div>

    
<!--底部开始-->

<!--底部开始-->

<div class="footer-wrap">

  <div class="footer ">

         <ul class="footer-nav">

            <li class="footer-nav-items footer-nav-title">帮助中心</li>

            <li class="footer-nav-items"><a href="#">常见问题</a></li>

            <li class="footer-nav-items"><a href="#">删除信息</a></li>

         </ul>

         <ul class="footer-nav">

            <li class="footer-nav-items footer-nav-title">关于我们</li>

            <li class="footer-nav-items"><a href="#">提供的服务</a></li>

            <li class="footer-nav-items"><a href="">联系我们</a></li>

         </ul>
          <ul class="footer-nav">

            <li class="footer-nav-items footer-nav-title">黑名单列表</li>

            <li class="footer-nav-items"><a href="#">法院公布黑名单</a></li>

            <li class="footer-nav-items"><a href="">P2P网贷黑名单</a></li>
            
            <li class="footer-nav-items"><a href="">私人举报黑名单</a></li>

         </ul>

         <ul class="contact-nav">

            <li class="contact-nav-items contact-nav-title">联系方式</li>

            <li class="contact-nav-items">客服QQ群：<span>304539080</span></li>

            <li class="contact-nav-items" style="position:relative;">在线咨询QQ：<span>121979164</span>
            <a href="http://wpa.qq.com/msgrd?v=3&site=点击查询&menu=yes&uin=121979164" title="点击咨询">
            <span class="ico-qq" alt="在线QQ咨询" title="在线QQ咨询"></span></a>
            
            </li>

            <li class="contact-nav-items">客服热线：<span>400-088-7296</span></li>

            <li class="contact-nav-items">技术支持邮箱：<span>121979164@qq.com</span></li>

            <li class="contact-nav-items">商务合作邮箱：<span>390015600@qq.com</span></li>

         </ul>

         <div class="erweima"><img src="/images/erweima.png" /></div>

     </div>
     
     <div class="clear"></div>
     
    <div class="copy-right-wap">
    
        <div class="cbody copy-right">
    
            <span style="padding-right:15px;">版权所有&copy;2012千久汇电子商务有限公司</span>
    
            <span>闽ICP备12018362号-3</span>
    
        </div>
    
    </div>
    
</div>

<!--回到顶部-->

<div class="gotoTOP"> <a href="#" onclick="gotoTop();return false;" class="totop"></a></div>


</body>
</html>

