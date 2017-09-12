using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace WeixinSDK.Work.Common.Tests
{
    [TestClass()]
    public class ApiClientBaseTests
    {
        private WeixinWorkApiClient _client;

        [TestInitialize]
        public void InitTest()
        {
            _client = new WeixinWorkApiClient(
                System.Configuration.ConfigurationManager.AppSettings["WeixinWork_CorpId"],
                System.Configuration.ConfigurationManager.AppSettings["WeixinWork_CorpSecret"]);
            _client.DumpRequest += info => { Console.WriteLine(JsonConvert.SerializeObject(info)); };
        }

        [TestMethod()]
        public void GetJsApiTicketTest()
        {
            var result = _client.GetJsSdkUiPackage("http://mp.weixin.qq.com");
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Signature);
            Assert.IsNotNull(result.Timestamp);
        }
    }
}