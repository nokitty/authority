using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace authority.Controllers
{
    /// <summary>
    /// 举报失信人
    /// </summary>
    public class ReportController : Controller
    {
        //
        // GET: /Report/

        public ActionResult Index()
        {
            if (Session["user"] == null)
                Redirect("~/login");
            return View();
        }

        //获取手机验证码
        public ActionResult GetCaptchas(string tel, string picverify)
        {
            var v = (string)Session["picVerify"];
            if (v != picverify)
            {
                Session.Remove("picVerify");
                return Content("验证码错误");
            }
            
            var rand = new Random();
            var captcha = rand.Next(1000000).ToString();

            var text = string.Format("欢迎使用查老赖平台,您的手机验证码是：{0}，请在10分钟内填写【查老赖】", captcha);
            var url = string.Format("http://sh2.ipyy.com/sms.aspx?action=send&userid=&account=600011&password=20255218&mobile={0}&content={1}&sendTime=&extno=", tel, Server.UrlEncode(text));

            WebClient wc = new WebClient();
            var res = wc.DownloadString(url);
            return Content("ok");
        }

        //被举报人详细信息
        public ActionResult Detail(string captcha)
        {
            var sc = (string)Session["captcha"];
            if (sc != captcha)
                return Content("验证码错误");

            return View();
        }

        //结果
        public ActionResult Result()
        {

            try
            {

                ////////////////////////////////
                ////测试使用的信息
                //var name = "uuz";
                //var sexy = "m";
                //var cardnum = "440681198808088888";
                //var province = "广东";
                //var city = "佛山";
                //var tel = "133230333253";
                //var arrears = 4000;
                //var count = 1;
                //var loanDate = DateTime.Now;
                //var repayDate = DateTime.Now;
                //var remark = "";
                ////////////////////////////////


                //被举报人姓名,性别,身份证号码后期需要经过验证才可以,防止垃圾信息进入数据库
                //被举报人名字
                var name = Tools.GetStringFromRequest(Request.Form["name"], "被举报人姓名不能为空");
                //var name = "uuz";
                //被举报人性别
                var sexy = Tools.GetStringFromRequest(Request.Form["sexy"], "性别不能为空");
                //var sexy = "m";
                //被举报人身份证号码
                var cardnum = Tools.GetStringFromRequest(Request.Form["cardnum"], "身份证号码不能为空");

                //省份,城市信息直接从网页上获取,不对真实性做验证,日后建立数据库,从数据库中获取,确保信息有效
                //省份
                var province = Tools.GetStringFromRequest(Request.Form["province"], "省份不能为空");
                //城市
                var city = Tools.GetStringFromRequest(Request.Form["city"], "城市不能为空");

                //手机号码
                var tel = Tools.GetStringFromRequest(Request.Form["tel"], "电话号码不能为空");
                //欠款金额
                var arrears = Tools.GetUIntFromRequest(Request.Form["arrears"], "欠款金额格式不正确");
                //欠款笔数
                var count = Tools.GetUIntFromRequest(Request.Form["count"], "欠款笔数不正确");

                //借款日期
                var loanDate = Tools.GetDateTimeFromRequest(Request.Form["loan-date"], "借款日期不正确");
                //还款日期
                var repayDate = Tools.GetDateTimeFromRequest(Request.Form["repay-date"], "还款日期不正确");
                //其他说明
                var remark = Request.Form["remark"];

                //上传的附件
                var pics = "";
                for (int i = 0, n = Request.Files.Count; i < n; i++)
                {
                    var file = Request.Files[i];

                    var buffer = MD5.Create().ComputeHash(file.InputStream);
                    var md5 = new StringBuilder();
                    foreach (var b in buffer)
                    {
                        md5.Append(b.ToString("x2"));
                    }

                    var ext = System.IO.Path.GetExtension(file.FileName);
                    var filename = md5.ToString() + ext;

                    pics += filename + "|";

                    file.SaveAs(Server.MapPath("~/upload/" + md5.ToString() + ext));
                }

                DBC.ReportedPerson.Create(name, sexy, cardnum, province, city, tel, arrears, count, loanDate, repayDate, remark, pics);

                return Content("资料上传完毕,问一下要不要设置悬赏啊之类的?");

            }
            catch (CLLParamException exception)
            {
                return Content(exception.Message);
            }
        }

        //举报信息列表
        public ActionResult List()
        {
            return View();
        }

        //获取图片验证码
        public ActionResult GetPicCaptchas()
        {
            var codeMaker = new VerifyCode();
            codeMaker.SetPageNoCache(Response);
            Session["picVerify"] = codeMaker.Paint(Response.OutputStream);
            return null;
        }
    }
}
