using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WeixinSDK.Work.Enums;
using WeixinSDK.Work.Models.Message;

namespace WeixinSDK.Work.Apis.Tests
{
    [TestClass()]
    public class MessageApiTests
    {
        private WeixinWorkApiClient _client;

        [TestInitialize]
        public void InitTest()
        {
            _client = new WeixinWorkApiClient(
                ConfigurationManager.AppSettings["WeixinWork_CorpId"],
                Convert.ToInt32(ConfigurationManager.AppSettings["WeixinWork_AgentId"]),
                ConfigurationManager.AppSettings["WeixinWork_CorpSecret"]);
            _client.DumpRequest += (info, type) => { Console.WriteLine(JsonConvert.SerializeObject(info)); };
        }

        [TestMethod()]
        public void SendTextTest()
        {
            var result = _client.Message.SendText(
                new SendTextRequest()
                {
                    UserIds = new List<string>() {"xiebt"},
                    text = new TextMessageInfo()
                    {
                        content =
                            "你的快递已到，请携带工卡前往邮件中心领取。\n出发前可查看<a href=\"http://op.huimaiche.com/HMCCarSourceOPWx\">邮件中心视频实况</a>，聪明避开排队。"
                    }
                }
            );

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }
    }
}