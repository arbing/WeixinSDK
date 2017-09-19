using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WeixinSDK.Work.Enums;

namespace WeixinSDK.Work.Apis.Tests
{
    [TestClass()]
    public class AgentTests
    {
        private WeixinWorkApiClient _client;

        [TestInitialize]
        public void InitTest()
        {
            _client = new WeixinWorkApiClient(
                ConfigurationManager.AppSettings["WeixinWork_CorpId"],
                ConfigurationManager.AppSettings["WeixinWork_AgentId"],
                ConfigurationManager.AppSettings["WeixinWork_CorpSecret"]);
            _client.DumpRequest += info => { Console.WriteLine(JsonConvert.SerializeObject(info)); };
        }

        [TestMethod()]
        public void GetTest()
        {
            var result = _client.Agent.Get(Convert.ToInt32(ConfigurationManager.AppSettings["WeixinWork_AgentId"]));

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }
    }
}