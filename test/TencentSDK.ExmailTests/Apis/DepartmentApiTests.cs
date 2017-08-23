using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TencentSDK.Exmail.Enums;
using TencentSDK.Exmail.Models.Department;

namespace TencentSDK.Exmail.Apis.Tests
{
    [TestClass()]
    public class DepartmentApiTests
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
            var result = _client.Department.Create(new CreateDepartmentRequest()
            {
                name = "测试部门",
                parentid = 1,
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
            Assert.IsTrue(result.id > 0);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var result = _client.Department.Update(new UpdateDepartmentRequest()
            {
                id = 123456789012345,
                name = "测试部门",
                parentid = 1,
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errcode);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var result = _client.Department.Delete(6468101396174010444);

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

            var departmentList = result.department.ToArray().Skip(1).Reverse()
                .Where(d => !new[] { "测试部门" }.Contains(d.name)).ToList();
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