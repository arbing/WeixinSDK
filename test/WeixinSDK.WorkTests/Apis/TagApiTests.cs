using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WeixinSDK.Work.Enums;
using WeixinSDK.Work.Models.Tag;

namespace WeixinSDK.Work.Apis.Tests
{
    [TestClass()]
    public class TagApiTests
    {
        private WeixinWorkApiClient _client;

        [TestInitialize]
        public void InitTest()
        {
            _client = new WeixinWorkApiClient(
                System.Configuration.ConfigurationManager.AppSettings["WeixinWork_CorpId"],
                System.Configuration.ConfigurationManager.AppSettings["WeixinWork_CorpSecret"]);
            _client.DumpRequest += (info, type) => { Console.WriteLine(JsonConvert.SerializeObject(info)); };
        }

        [TestMethod()]
        public void CreateTest()
        {
            var result = _client.Tag.Create(new CreateTagRequest()
            {
                tagname = "测试标签",
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.tagid > 0);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var result = _client.Tag.Update(new UpdateTagRequest()
            {
                tagid = 2,
                tagname = "测试标签",
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var result = _client.Tag.Delete(2);

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void GetTest()
        {
            var result = _client.Tag.Get(2);

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.userlist.Count > 0);
        }

        [TestMethod()]
        public void AddTagUsersTest()
        {
            var result = _client.Tag.AddTagUsers(new AddTagUsersRequest()
            {
                tagid = 2,
                userlist = new List<string>() { "test" },
                partylist = new List<int>() { 1 }
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void DelTagUsersTest()
        {
            var result = _client.Tag.DelTagUsers(new DelTagUsersRequest()
            {
                tagid = 2,
                userlist = new List<string>() { "test" },
                partylist = new List<int>() { 1 }
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void ListTest()
        {
            var result = _client.Tag.List();

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.taglist.Count > 0);
        }
    }
}