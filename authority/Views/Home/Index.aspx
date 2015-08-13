<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.idCard/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.idCard/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>首页</title>
<link rel="stylesheet" type="text/css" href="/css/base.css" />

<link rel="stylesheet" type="text/css" href="/css/index.css" />

<script type="text/javascript" src="/js/JQuery.js"></script>

<script type="text/javascript" src="/js/jquery-1.10.2.min.js"></script>

<script type="text/javascript" src="/js/common.js"></script>

<script type="text/javascript" src="/js/jquery.cookie.js"></script>

<script type="text/javascript" src="/js/law.js"></script>

<script type="text/javascript" src="/js/top.js"></script>

<script  type="text/javascript">

    var _hmt = _hmt || [];

    (function () {

        var hm = document.createElement("script");

        hm.src = "//hm.baidu.com/hm.js?108b1ab5c07ea8fc485b84aba397f856";

        var s = document.getElementsByTagName("script")[0];

        s.parentNode.insertBefore(hm, s);

    })();

</script>

</head>

<body>

<!--导航+banner-->

<div class="header">

    <!--头部导航-->

    <div class="header_tittle">
    
        <div class="header_Nav">
        
            <img src="/images/logo2.png"/>
            
            <ul>
                <li class="cur"><a href="/">首页</a></li>
                
                <li><a href="#" >信用查询</a></li>
                
                <li><a href="#">举报老赖</a></li>
                
                <li><a href="#">悬赏查询</a></li>
                
                <li><a href="#">关于我们</a></li>
            </ul>
            
            <div class="login">
            
                <a href="/login">登陆</a>/
                
                <a href="/signup">注册</a>
            
            </div>
            
        
        </div>
    
    </div>
    
   <!-- banner-->
   
    <div class="header_content">
    
        <!-- banner左边——排行榜 -->    
    
        <div class="header_content_left fl">
    
            <div class="buy_lf_ct_top  fl">
            
                <a class="cur" id="1" href="#"title="老赖黑名单" target="_blank"><span> 老赖黑名单</span></a>
                
                <a class="" id="2" href="#"title="悬赏排行版" target="_blank"><span> 悬赏排行版</span></a>
                
                <a class="" id="3" href="#"title="领赏排行榜" target="_blank"><span> 领赏排行榜</span></a>
            
            </div>
    
            <div class="buy_lf_ct_in ">
        
                <ul colid="1" style="display: block;" class="investor">
            
                    <li class="first">
                        
                        <span class="pic"></span>
                        
                        <span class="name">姓名</span>
                        
                        <span class="idCard">身份证号</span>
                        
                        <span class="position">目前住址</span>
                    
                    </li>

                    <li>
                    
                        <span class="pic"><img src="images/20150718043501_刘雪梅.png"></span>
                        
                        <span class="name"><a>刘雪梅</a></span>
                        
                        <span class="idCard">5104211987****2427</span>
                        
                        <span class="position"> 四川省攀枝花市米易县...</span>
                        
                    </li>

                    <li>
                    
                        <span class="pic"><img src="images/20150718042814_赵夫勇.png"></span>
                        
                        <span class="name"><a>赵夫勇</a></span>
                        
                        <span class="idCard">3713111984****4454</span>
                        
                        <span class="position">山东省临沂市罗庄区临...</span>
                        
                    </li>
                    
                    <li>
                    
                        <span class="pic"><img src="images/20150716025809_宋玉涛.png"></span>
                        
                        <span class="name"><a href="">宋玉涛</a></span>
                        
                        <span class="idCard"> 3713271972****022X</span>
                        
                        <span class="position">山东省临沂市莒南县长...</span>
                    
                    </li>

                    <li>
                    
                        <span class="pic"><img src="images/20150716025114_甘天鹏.png"></span>
                        
                        <span class="name"><a href="">甘天鹏</a></span>
                        
                        <span class="idCard">4508211984****0678</span>
                        
                        <span class="position">广西壮族自治区贵港市...</span>
                    
                    </li>

                    <div class="clear"></div>
                    
                    <a href="#" target="_blank" class="more">更多老赖黑名单></a>
            
                </ul>
            
                <ul colid="2" style="display: none;" class="zjxm">
                
                    <li class="first">
                    
                        <span class="time">悬赏排名</span>
                        
                        <span class="invest">悬赏人</span>
                        
                        <span class="idCard">被悬赏人</span>
                        
                        <span class="field">借贷类型</span>
                        
                        <span class="sum">悬赏金额</span>
                    
                    </li>
                
                    <li>
                    
                        <span class="time">1</span>
                        
                        <span class="invest">徐敏光</span>
                        
                        <span class="idCard">刘伟军</span>
                        
                        <span class="field">0</span>
                        
                        <span class="sum yellow">10000.00</span>
                    
                    </li>
                    
                    <li>
                    
                        <span class="time">2</span>
                        
                        <span class="invest">徐敏光</span>
                        
                        <span class="idCard">刘伟军</span>
                        
                        <span class="field">0</span>
                        
                        <span class="sum yellow">10000.00</span>
                    
                    </li>
                
                    <li>
                    
                        <span class="time">3</span>
                        
                        <span class="invest">徐敏光</span>
                        
                        <span class="idCard">刘伟军</span>
                        
                        <span class="field">0</span>
                        
                        <span class="sum yellow">10000.00</span>
                    
                    </li>
                
                    <li>
                    
                        <span class="time">4</span>
                        
                        <span class="invest">徐敏光</span>
                        
                        <span class="idCard">刘伟军</span>
                        
                        <span class="field">0</span>
                        
                        <span class="sum yellow">10000.00</span>
                    
                    </li>
                    
                    <div class="clear"></div>
                
                    <a href="###" id="T-zijin-url" target="_blank" class="more">更多悬赏榜单></a>
                    
                </ul>
            
                <ul colid="3" style="display: none;" class="zjxm">
                
                    <li class="first">
                    
                        <span class="bou_list">领赏排名</span>
                        
                        <span class="bou_men">领赏人</span>
                        
                        <span class="bou_pro">领赏项目</span>

                        <span class="bou_money">领赏金额</span>
                        
                    </li>
                
                    <li>
                    
                        <span class="bou_list">1</span>
                        
                        <span class="bou_men">李先生</span>
                        
                        <span class="bou_pro">追踪老赖，追踪老赖，追踪老赖</span>
                        
                        <span class="bou_money yellow">100.00</span>
                    
                    </li>
                
                    <li>
                    
                        <span class="bou_list">1</span>
                        
                        <span class="bou_men">李先生</span>
                        
                        <span class="bou_pro">追踪老赖，追踪老赖，追踪老赖</span>
                        
                        <span class="bou_money yellow">100.00</span>
                    
                    </li>
                
                    <li>
                    
                        <span class="bou_list">1</span>
                        
                        <span class="bou_men">李先生</span>
                        
                        <span class="bou_pro">追踪老赖，追踪老赖，追踪老赖</span>
                        
                        <span class="bou_money yellow">100.00</span>
                    
                    </li>
                
                    <li>
                    
                        <span class="bou_list">1</span>
                        
                        <span class="bou_men">李先生</span>
                        
                        <span class="bou_pro">追踪老赖，追踪老赖，追踪老赖</span>
                        
                        <span class="bou_money yellow">100.00</span>
                    
                    </li>
                    
                    <div class="clear"></div>
                
                    <a href="###" id="T-xiangmu-url" target="_blank" class="more">更多领赏榜单></a>
                
                </ul>
            
            </div>
            
        </div>
        
        <!--banner左边——排行榜-----------结束-->
        
		<script type="text/javascript">

		    var proj_id = $(".buy_lf_ct_top").find("a.cur").attr("id");

		    if (proj_id != "" && proj_id != undefined) {

		        $(".buy_lf_ct_in").find("ul").each(function () {

		            if ($(this).attr("colid") == proj_id) {

		                $(this).css("display", "block");

		            }

		        });

		    }

		    $(".buy_lf_ct_top").find("a").hover(function () {

		        $(".buy_lf_ct_top").find("a").removeClass();

		        $(this).addClass("cur");

		        var pid = $(this).attr("id");

		        $(".buy_lf_ct_in").find("ul").each(function () {

		            if ($(this).attr("colid") == pid) {

		                $(this).css("display", "block");

		            }

		            else {

		                $(this).css("display", "none");

		            }

		        });

		    });

        </script>

        <!--banner右边——查询-->  
         
        <div class="header_content_right fr">
   
            <div class="search">

                <img src="/images/guofenchaxun.png" />
      
                <div class="tips-out-wrap">
                
                    <div class="tips-error" id="tipsFormError"><span class="tips-error-msg"></span></div>
                
                </div>

                <ul id="searchFormId">
                
                    <li id="nameWrap">
                    
                        <input type="text" class="text" id="name" data-valida-input="false" placeholder="请输入要查询的姓名"  />
                    
                    </li>
                    
                    <li id="idcardWrap">
                    
                        <input type="text" class="text-tel" id="idcard" data-valida-input="true" placeholder="请输入身份证号码(选填)"/>
                    
                    </li>
                    
                    <li>
                    
                        <a href="javascript:;" class="btn"  id="toSearch" onClick="toSearch()"></a>
                        
                        <a href="login.html" class="btn2"></a>
                    
                    </li>
                
                </ul>

            </div>
            
        </div>
    
    </div>
    
    </div>
    
   <!-- header_content结束-->
</div>

<!--header结束-->

<!--内容开始-->

<div class="content_con">

    <!--投资机构开始-->

    <div class="institution">
    
        <div class="inst-title">投资机构</div>
        
        <ul class="clearfix">
            
            <li><a href="/org/detail_43.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_01.jpg" alt="IDG 资本"></a></li>
            
            <li><a href="/org/detail_73.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_02.jpg" alt="戈壁投资"></a></li>
            
            <li><a href="/org/detail_244.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_03.jpg" alt="纪源资本"></a></li>
            
            <li><a href="/org/detail_203.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_04.jpg" alt="经纬中国"></a></li>
            
            <li><a href="/org/detail_745.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_05.jpg" alt="老虎基金"></a></li>
            
            <li><a href="/org/detail_255.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_06.jpg" alt="红杉资本"></a></li>
            
            <li><a href="/org/detail_89.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_07.jpg" alt="凯雷投资"></a></li>
            
            <li><a href="/org/detail_198.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_08.jpg" alt="中科招商"></a></li>
            
            <li><a href="/org/detail_104.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_09.jpg" alt="启明创投"></a></li>
            
            <li><a href="/org/detail_1.html" target="_blank"><img src="http://yf.trjcn.com/rongzi/18/images/show_pic_10.jpg" alt="软银中国"></a></li>
        
        </ul>
    
    </div>

    <!--投资机构结束-->
    
    <!--咨询开始-->

    <div class="adv">
        
        <div class="fl adv_indus">
        
            <h3><span class="fr more2"><a href="/news/list" target="_blank">更多</a></span>行业咨询</h3>
            
            <ul class="adv_indus_content">
                <%foreach (DBC.Article item in ViewBag.articlelist)
                  {
                      %>
                     <li >                 
                    <span class="fr"><%=DateTime.Now.ToString("yyyy年MM月dd日")%></span>
                    <a href="/news/details?id=<%=item.ID %>" target="_blank" title=""><%=item.Title %></a>  
                    <img alt="新" src="/images/new3.gif">                  
                </li>  
                    <%
                  } %>                            
            </ul>
        
        </div>
        
        <div class="fl adv_indus">
        
            <h3><span class="fr more2"><a href="/announcement/list" target="_blank">更多</a></span>公司公告</h3>
            
            <ul class="adv_indus_content">
                <% foreach (DBC.Announcement item in ViewBag.announcementlist)
                   {
                     %>
                    <li>                    
                    <span class="fr"><%=DateTime.Now.ToString("yyyy年MM月dd日")%></span>                    
                    <a href="/announcement/details?id=<%=item.ID %>"><%=item.Title %>></a>
                
                </li>
                    <%
                   }   %>   
            </ul>
        
        </div>
        
        <div class=" fr adv_faq">
        
            <h3><span class="fr more2"><a href="/qna/list" target="_blank">更多</a></span>常见问题与解答</h3>
            
            <div id="ulOrderAnns">
                <div class="adv_faq_content">
                <%foreach (DBC.QnA item in ViewBag.qnaList)
                  {
                      %>
                    <dl>
                        <dt><span><a href="#" looyu_bound="1">
                            <%=item.Question %></a></span></dt>
                        <dd><span><%=item.Answer %></span></dd>
                    </dl>
                      <%
                  } %>
                </div>
            
            </div>        
            
        </div>
        
    <script type="text/javascript" src="js/MSClass.js"></script> 
        
    <script type="text/javascript">

        new Marquee("ulOrderAnns", 0, 1, 270, 260, 20, 0, 1024, 22);

    </script>
    
    </div>
    
    <!--咨询结束-->
    
    <div class="clear"></div>
    
    <!--链接-->
    
    <div class="link clearfix">
    
    <h3><a href="#" title="友情链接" target="_blank" looyu_bound="1"><img src="/images/link.gif"></a></h3>
    
    <div class="link-con clearfix">
        
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
            拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
            拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
            拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
        <span><a href="#" title="拍拍贷" target="_blank" looyu_bound="1">
             拍拍贷 </a>|</span>
    </div>
</div>

</div>

<!--内容结束-->

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
    
            <span>粤ICP备15069453号</span>
    
        </div>
    
    </div>
    
</div>

<!--回到顶部-->

<div class="gotoTOP"> <a href="#" onclick="gotoTop();return false;" class="totop"></a></div>


</body>
</html>