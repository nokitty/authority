<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.idCard/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.idCard/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>注册</title>
<link rel="stylesheet" type="text/css" href="/css/base.css" />

<link rel="stylesheet" type="text/css" href="/css/index.css" />

<link rel="stylesheet" type="text/css" href="/css/style.css" />

<link rel="stylesheet" type="text/css" href="/css/style1.css" />

<script type="text/javascript" src="/js/jquery.min.js"></script>

<script type="text/javascript" src="/js/jquery-1.10.2.min.js"></script>

<script type="text/javascript" src="/js/common.js"></script>

<script type="text/javascript" src="/js/jquery.cookie.js"></script>

<script type="text/javascript" src="/js/law.js"></script>

</head>

<body>

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
            
                <a href="login">登陆</a>/
                
                <a href="signup">注册</a>
            
            </div>
    
    </div>

</div>
    
<!--header结束-->

<div class="content_con">

    <div class="inst-title">当前位置：<a href="index.html">首页</a>/黑名单列表</div>
      
    <div class="register_tittle">
    
        <p ><span class="cur_register">填写账户信息</span><span>完善用户详细资料</span><span>注册成功</span></p>
    
    </div>
    
    <div class="register_content">
      
        <div class="blackb_box">
      
            <div class="blackb_bk">
            
                <p class="new_register">新用户注册</p>
                
                <form name="regform" method="post" action="?action=add&amp;&amp;kf=" id="regform">
                
                <input type="hidden" name="__VIEWSTATE" id="__VIEWSTATE" value="">

                    <div class="register_box">
                        <dl>
                            <dt>注册邮箱：</dt>
                            
                            <dd>
                            
                            <input name="Email" type="text" id="Email" size="40" class="register_input"> 
                            <span style="color:red">*</span> <span id="spanEmail" style="color: Red"></span>
                            
                            </dd>
                            
                        </dl>
                        <dl>
                            <dt>用户名：</dt>
                            <dd>
                            
                            <input name="UserName" type="text" id="UserName" size="40" class="register_input" onclick="document.getElementById('spanUserName').innerHTML = '由数字、字母和下划线组成';"> 
                            <span style="color:red">*</span> <span id="spanUserName" style="color: Red"></span></dd>
                        </dl>
                        <dl>
                            <dt>创建密码：</dt>
                            <dd><input name="Password" type="password" id="Password" maxlength="17" onclick="document.getElementById('spanPassword').innerHTML = '密码不能小于6位';" size="40" class="register_input"> <span style="color:red">*</span> <span id="spanPassword" style="color: Red"></span></dd>
                        </dl>
                        <dl>
                            <dt>确认密码：</dt>
                            <dd><input name="relPass" type="password" id="relPass" maxlength="17" size="40" class="register_input"> <span style="color:red">*</span> <span id="spanRelPass" style="color: Red"></span></dd>
                        </dl>
                        <dl>
                            <dt>用户类型：</dt>
                            <dd><select name="currentRole" id="currentRole" style="width: 145px" class="register_input">
	<option selected="selected" value="机构用户">机构用户</option>
	<option value="个人用户">个人用户</option>
</select> <span style="color:red; font-size:12px;">* 公司、企业、团体请选择机构用户，P2P网站请直接联系客服索取账号。</span> <span id="span1" style="color: Red"></span></dd>
                        </dl>
                        <dl>
                            <dt>客户来源：</dt>
                            <dd><select name="userFrom" id="userFrom" style="width: 145px" class="register_input">
	<option selected="selected" value="--请选择--">--请选择--</option>
	<option value="报纸报道">报纸报道</option>
	<option value="百度搜索">百度搜索</option>
	<option value="屏幕广告">屏幕广告</option>
	<option value="朋友介绍">朋友介绍</option>
	<option value="论坛博客">论坛博客</option>
	<option value="网络广告">网络广告</option>
	<option value="客服联络">客服联络</option>
	<option value="其他">其他</option>
</select> <span style="color:red">*</span> <span id="span2" style="color: Red"></span></dd>
                        </dl>
                        <dl>
                            <dt>区 域：</dt>
                            <dd>
                                <select id="province" name="province" class="register_input"><option value="">请选择省</option>
<option value="1">北京市</option>
<option value="2">天津市</option>
<option value="3">河北省</option>
<option value="4">山西省</option>
<option value="5">内蒙古自治区</option>
<option value="6">辽宁省</option>
<option value="7">吉林省</option>
<option value="8">黑龙江省</option>
<option value="9">上海市</option>
<option value="10">江苏省</option>
<option value="11">浙江省</option>
<option value="12">安徽省</option>
<option value="13">福建省</option>
<option value="14">江西省</option>
<option value="15">山东省</option>
<option value="16">河南省</option>
<option value="17">湖北省</option>
<option value="18">湖南省</option>
<option value="19">广东省</option>
<option value="20">广西壮族自治区</option>
<option value="21">海南省</option>
<option value="22">重庆市</option>
<option value="23">四川省</option>
<option value="24">贵州省</option>
<option value="25">云南省</option>
<option value="26">西藏自治区</option>
<option value="27">陕西省</option>
<option value="28">甘肃省</option>
<option value="29">青海省</option>
<option value="30">宁夏回族自治区</option>
<option value="31">新疆维吾尔自治区</option>
<option value="32">香港特别行政区</option>
<option value="33">澳门特别行政区</option>
<option value="34">台湾省</option>
<option value="35">未知省</option>
</select>
                                <select id="city" name="city" class="register_input">
                                    <option value="">请选择市</option>
                                </select>
                                <select id="district" name="district" class="register_input">
                                    <option value="">请选择区(县)</option>
                                </select>
                                 <span id="spanArea" style="color: Red"></span>
                            </dd>
                        </dl>
                        <dl>
                            <dt>验证码：</dt>
                            <dd>
                                <input name="code" id="code" onkeyup="value=value.replace(/[^\d]/g,'')" type="text" size="10" class="register_input" maxlength="4"> <img id="imgCode" src="Inc/CheckCode.aspx" alt="验证码，单击更换" style="width: 61px; height: 24px" class="vMiddle"> <span id="spanCode" style="color: Red"></span>
                            </dd>
                        </dl>
                        <dl>
                            <dt>&nbsp; </dt>
                            <dd>
                                <input id="Checkbox1" checked="checked" type="checkbox" style="vertical-align:middle;" onclick="rw()">
                                <a href="#" onclick="PropDiv('safety/register_saft.aspx',995,0)" style="color: #3372a2; font-size:12px;">
                                    我已阅读并同意使用条款及隐私条款</a>
                            </dd>
                        </dl>
                        <dl>
                            <dt>&nbsp; </dt>
                            <dd>
                                <input name="buttSinUp" type="button" id="buttSinUp" style="" class="register_inimg">
                                
                            </dd>
                        </dl>
                        
                    </div>
                    
                </form>
        
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

         <div class="erweima"><img src="images/erweima.png" /></div>

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

