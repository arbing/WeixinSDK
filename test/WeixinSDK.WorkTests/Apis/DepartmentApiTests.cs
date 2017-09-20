using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WeixinSDK.Work;
using WeixinSDK.Work.Enums;
using WeixinSDK.Work.Models.Department;

namespace WeixinSDK.WorkTests.Apis
{
    [TestClass()]
    public class DepartmentApiTests
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
            var result = _client.Department.Create(new CreateDepartmentRequest()
            {
                name = "测试部门",
                parentid = 1,
                id = 10,
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.AreEqual(result.id, 10);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var result = _client.Department.Update(new UpdateDepartmentRequest()
            {
                id = 1,
                name = "惠买车",
                parentid = null,
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var result = _client.Department.Delete(10);

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void ListTest()
        {
            var result = _client.Department.List();

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.department.Count > 0);

        }

        [TestMethod()]
        public void DeleteAllTest()
        {
            var result = _client.Department.List();

            var departmentList = result.department.ToArray().Skip(1).Reverse().ToList();
            foreach (var info in departmentList)
            {
                var res = _client.Department.Delete(info.id);
                if (res.errcode != ReturnCode.请求成功)
                {
                    Console.WriteLine("{0}({1}):{2}", (int)res.errcode, res.errcode, res.errmsg);
                }
                Thread.Sleep(50);
            }
        }
    }
}