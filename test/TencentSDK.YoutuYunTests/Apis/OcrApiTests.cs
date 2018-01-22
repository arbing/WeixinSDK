using Microsoft.VisualStudio.TestTools.UnitTesting;
using TencentSDK.YoutuYun.Apis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TencentSDK.YoutuYun.Enums;
using TencentSDK.YoutuYun.Models.Ocr;

namespace TencentSDK.YoutuYun.Apis.Tests
{
    [TestClass()]
    public class OcrApiTests
    {
        private YoutuYunApiClient _client;

        [TestInitialize]
        public void InitTest()
        {
            _client = new YoutuYunApiClient(
                ConfigurationManager.AppSettings["YoutuYun_AppId"],
                ConfigurationManager.AppSettings["YoutuYun_SecretId"],
                ConfigurationManager.AppSettings["YoutuYun_SecretKey"],
                ConfigurationManager.AppSettings["YoutuYun_UserId"]);
            _client.DumpRequest += (info, type) => { Console.WriteLine(JsonConvert.SerializeObject(info)); };
        }

        [TestMethod()]
        public void GeneralOcrTest_Url()
        {
            var result = _client.Ocr.GeneralOcr(new GeneralOcrRequest()
            {
                url = @"http://open.youtu.qq.com/app/img/experience/char_general/ocr_common01.jpg"
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.请求成功, result.errorcode);
            Console.WriteLine(result.errormsg);
        }


        [TestMethod()]
        public void GeneralOcrTest_UrlGif()
        {
            var result = _client.Ocr.GeneralOcr(new GeneralOcrRequest()
            {
                url = @"https://ss1.bdstatic.com/70cFvXSh_Q1YnxGkpoWK1HF6hhy/it/u=139136134,862152765&fm=27&gp=0.jpg"
            });

            Assert.IsNotNull(result);
            Assert.AreEqual(ReturnCode.图片解码失败, result.errorcode);
            Console.WriteLine(result.errormsg);
        }
    }
}