using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeixinSDK.Work.Enums;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Common
{
    /// <summary>
    /// HTTP请求方法
    /// </summary>
    public class RequestClient
    {
        /// <summary>
        /// HTTP请求信息和响应信息处理
        /// </summary>
        /// <param name="requestInfo"></param>
        public delegate void DumpRequestHandler(object requestInfo);

        /// <summary>
        /// HTTP请求信息和响应信息处理事件
        /// </summary>
        public event DumpRequestHandler DumpRequest;

        /// <summary>
        /// 发送HTTP请求
        /// </summary>
        /// <param name="requestUri">请求Uri，相对于BaseUri</param>
        /// <param name="queryObj">解析查询对象(POCO对象)</param>
        /// <param name="bodyObj">上传数据对象(POCO对象)</param>
        /// <param name="method">HTTP操作方法</param>
        /// <returns>返回数据</returns>
        /// <exception cref="ArgumentNullException">请求Uri为空</exception>
        public string Send(string requestUri, object queryObj, object bodyObj = null,
            HttpMethod method = HttpMethod.GET)
        {
            if (string.IsNullOrEmpty(requestUri))
            {
                throw new ArgumentException("requestUri");
            }

            if (method == HttpMethod.GET && bodyObj != null)
            {
                throw new InvalidOperationException("Get request cant't contain body");
            }

            IDictionary<string, string> parameters = new Dictionary<string, string>();
            if (queryObj != null)
            {
                var jobj = JObject.FromObject(queryObj);
                foreach (var property in jobj.Properties())
                {
                    var jvalue = property.Value as JValue;
                    if (jvalue != null && jvalue.Value != null)
                    {
                        parameters[property.Name] = property.Value.ToString();
                    }
                }
            }

            if (parameters.Count > 0)
            {
                var queryToAppend = "?" + string.Join("&",
                                        parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));
                requestUri += queryToAppend;
            }

            var body = "";
            if (bodyObj != null)
            {
                body = JsonConvert.SerializeObject(bodyObj);
            }

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(requestUri);
            request.Timeout = 10 * 1000;
            request.Method = method.ToString().ToUpper();
            request.ContentType = "application/json;charset=UTF-8";

            if (method != HttpMethod.GET && !string.IsNullOrEmpty(body))
            {
                var encoding = Encoding.UTF8;
                if (!string.IsNullOrEmpty(body))
                {
                    byte[] buffer = encoding.GetBytes(body);

                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(buffer, 0, buffer.Length);
                    }
                }
            }

            var requestId = Guid.NewGuid();
            HttpWebResponse response = null;
            string responseTxt = null;

            try
            {
                // 请求前打印请求信息
                if (DumpRequest != null)
                {
                    DumpRequest(new
                    {
                        RequestId = requestId,
                        Type = "Request",
                        Uri = request.RequestUri,
                        request.Method,
                        request.ContentType,
                        Content = body
                    });
                }

                response = (HttpWebResponse) request.GetResponse();

                // 请求返回正常
                responseTxt = ReadResponseStream(response);

                // 请求返回后打印响应信息
                if (DumpRequest != null)
                {
                    DumpRequest(new
                    {
                        RequestId = requestId,
                        Type = "Response",
                        Uri = response.ResponseUri,
                        response.Method,
                        response.ContentType,
                        Content = responseTxt
                    });
                }
            }
            catch (WebException webEx)
            {
                // 请求异常打印响应信息
                if (DumpRequest != null)
                {
                    DumpRequest(new
                    {
                        RequestId = requestId,
                        Type = "Error",
                        Uri = request.RequestUri,
                        Status = webEx.Status.ToString(),
                        webEx.Message,
                    });
                }

                var res = new JsonResult {errcode = ReturnCode.系统繁忙, errmsg = webEx.Message};
                responseTxt = JsonConvert.SerializeObject(res);
            }

            return responseTxt;
        }

        private static string ReadResponseStream(HttpWebResponse response)
        {
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    var retString = streamReader.ReadToEnd();
                    return retString;
                }
            }
        }

        

    }

    /// <summary>
    /// HTTP请求方法
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>
        /// GET
        /// </summary>
        GET,

        /// <summary>
        /// POST
        /// </summary>
        POST,

        /// <summary>
        /// PUT
        /// </summary>
        PUT,

        /// <summary>
        /// DELETE
        /// </summary>
        DELETE,

        /// <summary>
        /// HEAD
        /// </summary>
        HEAD,

        /// <summary>
        /// OPTIONS
        /// </summary>
        OPTIONS,

        /// <summary>
        /// PATCH
        /// </summary>
        PATCH,
    }
}
