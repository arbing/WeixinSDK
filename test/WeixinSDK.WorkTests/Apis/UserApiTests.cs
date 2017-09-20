using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WeixinSDK.Work;
using WeixinSDK.Work.Enums;
using WeixinSDK.Work.Models.User;

namespace WeixinSDK.WorkTests.Apis
{
    [TestClass()]
    public class UserApiTests
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
            var result = _client.User.Create(new CreateUserRequest()
            {
                userid = "test",
                name = "测试",
                mobile = "18812345678",
                department = new List<int>() { 10 }
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void GetTest()
        {
            var result = _client.User.Get("test");

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.AreEqual(result.userid, "test");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var result = _client.User.Update(new UpdateUserRequest()
            {
                userid = "test",
                name = "测试",
                mobile = "18812345678",
                department = new List<int>() { 10 }
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var result = _client.User.Delete("test");

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void BatchDeleteTest()
        {
            var result = _client.User.BatchDelete(new List<string>() { "test" });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void SimpleListTest()
        {
            var result = _client.User.SimpleList(1, 1);

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.userlist.Count > 0);
        }

        [TestMethod()]
        public void ListTest()
        {
            var result = _client.User.List(1, 1);

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.userlist.Count > 0);
        }

        [TestMethod()]
        public void GetUserInfoTest()
        {
            var result = _client.User.GetUserInfo("xxx");

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.AreEqual(result.UserId, "test");
        }
 
        [TestMethod()]
        public void DeleteAllTest()
        {
            var result = _client.User.SimpleList(1, 1);

            var userlist = result.userlist.Where(d => !new[] { "test"}.Contains(d.userid));
            foreach (var user in userlist)
            {
                var res = _client.User.Delete(user.userid);
                if (res.errcode != ReturnCode.请求成功)
                {
                    Console.WriteLine("{0}({1}):{2}", (int)res.errcode, res.errcode, res.errmsg);
                }
                Thread.Sleep(50);
            }
        }
   }
}