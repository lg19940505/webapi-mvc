using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Security;
using Util;

namespace API_TEST.Controllers
{
   [RoutePrefix("User")]
    public class UserController :ApiController
    {
        public string GetAllChargingData()
        {
            return "Success";
        }

        /// <summary>
        /// 得到用户信息组
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetUser/{id:int=3}")]
        [HttpGet]
        public JsonResultModel<List<UserInfo>> GetUser(int id)
        {
            UserInfo person = new UserInfo();
            person.bRes = true;
            person.UserName = "lg"+id;
            person.Password = "123";
            person.Ticket = "lg123";
            List<UserInfo> list = new List<UserInfo>();
            list.Add(person);
            UserInfo person1 = new UserInfo();
            person1.bRes = true;
            person1.UserName = "wmy";
            person1.Password = "123";
            person1.Ticket = "lg123";
            list.Add(person1);
            return JsonResultModel<List<UserInfo>>.ReturnSuccess(list);
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUser"></param>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        [HttpGet]
        public string Login(string strUser, string strPwd)
        {
            if (!ValidateUser(strUser, strPwd))
            {
                return "false";
            }
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(0, strUser, DateTime.Now,
                            DateTime.Now.AddHours(1), true, string.Format("{0}&{1}", strUser, strPwd),
                            FormsAuthentication.FormsCookiePath);
            //返回登录结果、用户信息、用户验证票据信息
            var oUser = new UserInfo { bRes = true, UserName = strUser, Password = strPwd, Ticket = FormsAuthentication.Encrypt(ticket) };
            //将身份信息保存在session中，验证当前请求是否是有效请求
            HttpContext.Current.Session["admin"] = "123456";
           
            return oUser.Ticket;
        }
        

        //校验用户名密码（正式环境中应该是数据库校验）
        private bool ValidateUser(string strUser, string strPwd)
        {
            if (strUser == "admin" && strPwd == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class UserInfo
    {
        public bool bRes { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Ticket { get; set; }
    }
}
