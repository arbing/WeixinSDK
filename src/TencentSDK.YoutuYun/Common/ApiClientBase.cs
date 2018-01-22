using System;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using TencentSDK.YoutuYun.Enums;
using TencentSDK.YoutuYun.Models.Common;

namespace TencentSDK.YoutuYun.Common
{
    /// <summary>
    /// 腾讯优图API客户端基类
    /// </summary>
    public class ApiClientBase : RequestClient
    {
        /// <summary>
        /// 基地址
        /// </summary>
        public const string BaseUrl = "https://api.youtu.qq.com";

        /// <summary>
        /// 应用的AppId
        /// </summary>
        public string AppId { get; private set; }

        /// <summary>
        /// 应用的SecretID
        /// </summary>
        public string SecretId { get; private set; }

        /// <summary>
        /// 应用的SecretKey
        /// </summary>
        public string SecretKey { get; private set; }

        /// <summary>
        /// 应用的UserId
        /// </summary>
        public string UserId { get; private set; }

        /// <summary>
        /// 应用的鉴权签名串
        /// </summary>
        public AuthorizationResult AuthorizationResult { get; private set; }

        /// <summary>
        /// 初始化腾讯优图API客户端
        /// </summary>
        /// <param name="appId">应用的AppId</param>
        /// <param name="secretId">应用的SecretID</param>
        /// <param name="secretKey">应用的SecretKey</param>
        /// <param name="userId">应用的UserId</param>
        public ApiClientBase(string appId, string secretId, string secretKey, string userId)
        {
            AppId = appId;
            SecretId = secretId;
            SecretKey = secretKey;
            UserId = userId;
        }

        /// <summary>
        /// 获取鉴权签名串
        /// </summary>
        public AuthorizationResult GetAuthorization()
        {
            if (AuthorizationResult == null || AuthorizationResult.ExpireTime <= DateTime.Now)
            {
                DateTime expireTime = DateTime.Now.AddDays(30);
                string signStr = Sign(expireTime);
                var result = new AuthorizationResult(){ SignStr = signStr , ExpireTime = expireTime };
                AuthorizationResult = result;
                return result;
            }
            else
            {
                return AuthorizationResult;
            }
        }

        /// <summary>
        /// HMAC-SHA1 算法签名
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private byte[] HmacSha1Sign(string str, string key)
        {
            byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);
            HMACSHA1 hmac = new HMACSHA1(keyBytes);
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(str);
            return hmac.ComputeHash(inputBytes);
        }

        /// <summary>
        /// 字节数组合并
        /// </summary>
        /// <param name="byte1"></param>
        /// <param name="byte2"></param>
        /// <returns></returns>
        private byte[] JoinByteArr(byte[] byte1, byte[] byte2)
        {
            byte[] full = new byte[byte1.Length + byte2.Length];
            Stream s = new MemoryStream();
            s.Write(byte1, 0, byte1.Length);
            s.Write(byte2, 0, byte2.Length);
            s.Position = 0;
            int r = s.Read(full, 0, full.Length);
            if (r > 0)
            {
                return full;
            }
            throw new Exception("读取错误!");
        }

        private string Sign(DateTime expireTime)
        {
            string orignal = string.Format("u={0}&a={1}&k={2}&e={3}&t={4}&r={5}&f={6}", UserId, AppId, SecretId,
                expireTime.ToUnixTime(), DateTime.Now.ToUnixTime(), new Random()
                    .Next(0, 1000000000), "");

            byte[] signByteArrary = JoinByteArr(HmacSha1Sign(orignal, SecretKey),
                System.Text.Encoding.UTF8.GetBytes(orignal));

            return Convert.ToBase64String(signByteArrary);
        }

        /// <summary>
        /// GET方式请求URL，并返回T类型
        /// </summary>
        /// <param name="requestUri">请求Uri，相对于BaseUri</param>
        /// <param name="queryObj">解析查询对象(POCO对象)</param>
        /// <returns>返回数据</returns>
        public T GetAsJson<T>(string requestUri, object queryObj) where T : JsonResult
        {
            var url = BaseUrl + requestUri;
            string returnText = Send(url, queryObj, null, GetAuthorization().SignStr, HttpMethod.GET);

            T result = JsonConvert.DeserializeObject<T>(returnText);

            // 错误码替换成错误描述
            if (ErrorMsgs.Map.ContainsKey(result.errormsg))
            {
                result.errormsg = ErrorMsgs.Map[result.errormsg];
            }
            return result;
        }

        /// <summary>
        /// 发起Post请求，并返回T类型
        /// </summary>
        /// <param name="requestUri">请求Uri，相对于BaseUri</param>
        /// <param name="queryObj">解析查询对象(POCO对象)</param>
        /// <param name="bodyObj">上传数据对象(POCO对象)</param>
        /// <returns>返回数据</returns>
        public T PostAsJson<T>(string requestUri, object queryObj, object bodyObj) where T : JsonResult
        {
            var url = BaseUrl + requestUri;
            string returnText = Send(url, queryObj, bodyObj, GetAuthorization().SignStr, HttpMethod.POST);

            T result = JsonConvert.DeserializeObject<T>(returnText);

            // 错误码替换成错误描述
            if (ErrorMsgs.Map.ContainsKey(result.errormsg))
            {
                result.errormsg = ErrorMsgs.Map[result.errormsg];
            }

            return result;
        }
    }
}
