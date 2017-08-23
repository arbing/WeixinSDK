using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TencentSDK.Exmail.Enums;
using TencentSDK.Exmail.Models.User;

namespace TencentSDK.Exmail.Apis.Tests
{
    [TestClass()]
    public class UserApiTests
    {
        private TencentExmailApiClient _client;

        [TestInitialize]
        public void InitTest()
        {
            _client = new TencentExmailApiClient(
                System.Configuration.ConfigurationManager.AppSettings["TencentExmail_CorpId"],
                System.Configuration.ConfigurationManager.AppSettings["TencentExmail_CorpSecret"]);
            _client.DumpRequest += info => { Console.WriteLine(JsonConvert.SerializeObject(info)); };
        }

        [TestMethod()]
        public void CreateTest()
        {
            var result = _client.User.Create(new CreateUserRequest()
            {
                userid = "test@test.com",
                name = "测试",
                mobile = "18812345678",
                department = new List<long>() { 6468101396174010444 },
                password = "Test.123"
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void GetTest()
        {
            var result = _client.User.Get("test@test.com");

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.AreEqual(result.userid, "test@test.com");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var result = _client.User.Update(new UpdateUserRequest()
            {
                userid = "test@test.com",
                name = "测试",
                mobile = "18812345678",
                department = new List<long>() { 6468101396174010444 }
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var result = _client.User.Delete("test@test.com");

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
        public void DeleteAllTest()
        {
            var result = _client.User.SimpleList(1, 1);

            var userlist = result.userlist;
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