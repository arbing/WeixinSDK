using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TencentSDK.YoutuYun.Enums;
using TencentSDK.YoutuYun.Models.Common;

namespace TencentSDK.YoutuYun.Common
{
    /// <summary>
    /// HTTP请求信息和响应信息处理
    /// </summary>
    /// <param name="requestInfo">HTTP请求信息和响应信息</param>
    /// <param name="type">信息类型：Request、Response、Error</param>
    public delegate void DumpRequestHandler(object requestInfo, string type = "");

    /// <summary>
    /// 企业微信API返回错误处理
    /// </summary>
    /// <param name="ex">错误信息</param>
    public delegate void ApiErrorHandler(Exception ex);

    /// <summary>
    /// HTTP请求方法
    /// </summary>
    public class RequestClient
    {
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
        /// <param name="authorization">授权签名串</param>
        /// <param name="method">HTTP操作方法</param>
        /// <returns>返回数据</returns>
        /// <exception cref="ArgumentNullException">请求Uri为空</exception>
        public string Send(string requestUri, object queryObj, object bodyObj = null, string authorization = null,
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
            request.Method = method.ToString().ToUpper();
            request.ContentType = "text/json";

            if (!string.IsNullOrEmpty(authorization))
            {
                request.Headers.Add(HttpRequestHeader.Authorization, authorization);
            }

            if (method != HttpMethod.GET && !string.IsNullOrEmpty(body))
            {
                var encoding = Encoding.UTF8;
                if (!string.IsNullOrEmpty(body))
                {
                    byte[] buffer = encoding.GetBytes(body);
                    request.ContentLength = buffer.Length;

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
                        Type = "Request",
                        Id = requestId,
                        Uri = request.RequestUri,
                        request.Method,
                        request.ContentType,
                        Authorization = authorization,
                        Content = body
                    }, "Request");
                }

                response = (HttpWebResponse) request.GetResponse();

                // 请求返回正常
                responseTxt = ReadResponseStream(response);

                // 请求返回后打印响应信息
                if (DumpRequest != null)
                {
                    DumpRequest(new
                    {
                        Type = "Response",
                        Id = requestId,
                        Uri = request.RequestUri,
                        response.ContentType,
                        Content = responseTxt
                    }, "Response");
                }
            }
            catch (WebException webEx)
            {
                response = webEx.Response as HttpWebResponse;

                if (response != null)
                {
                    var content = ReadResponseStream(response);

                    // 请求异常打印响应信息
                    if (DumpRequest != null)
                    {
                        DumpRequest(new
                        {
                            Type = "Error",
                            Id = requestId,
                            Uri = request.RequestUri,
                            Status = webEx.Status.ToString(),
                            webEx.Message,
                            Content = content
                        }, "Error");
                    }

                    responseTxt =
                        JsonConvert.SerializeObject(
                            new JsonResult
                            {
                                errorcode = (ReturnCode) (int) response.StatusCode,
                                errormsg = webEx.Message
                            });

                }
                else
                {
                    // 请求异常打印响应信息
                    if (DumpRequest != null)
                    {
                        DumpRequest(new
                        {
                            Type = "Error",
                            Id = requestId,
                            Uri = request.RequestUri,
                            Status = webEx.Status.ToString(),
                            webEx.Message,
                        }, "Error");
                    }

                    responseTxt =
                        JsonConvert.SerializeObject(
                            new JsonResult {errorcode = ReturnCode.系统繁忙, errormsg = webEx.Message});

                }
            }

            return responseTxt;
        }

        private static string ReadResponseStream(HttpWebResponse response)
        {
            using (Stream responseStream = response.GetResponseStream())
            {
                if (responseStream == null)
                {
                    return null;
                }
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
