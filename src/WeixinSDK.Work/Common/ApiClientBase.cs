using System;
using Newtonsoft.Json;
using WeixinSDK.Work.Enums;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Common
{
    /// <summary>
    /// 企业微信API客户端基类
    /// </summary>
    public class ApiClientBase : RequestClient
    {
        /// <summary>
        /// 企业微信API返回错误处理事件
        /// </summary>
        public event ApiErrorHandler ApiError;

        /// <summary>
        /// 基地址
        /// </summary>
        public const string BaseUrl = "https://qyapi.weixin.qq.com/cgi-bin";

        /// <summary>
        /// 企业ID
        /// </summary>
        public string CorpId { get; private set; }

        /// <summary>
        /// 企业应用的ID
        /// </summary>
        public int AgentId { get; private set; }

        /// <summary>
        /// 应用的凭证密钥
        /// </summary>
        public string CorpSecret { get; private set; }

        /// <summary>
        /// 应用的AccessToken
        /// </summary>
        public AccessTokenResult AccessTokenResult { get; private set; }

        /// <summary>
        /// 应用的JsApi凭证
        /// </summary>
        public JsApiTicketResult JsApiTicketResult { get; private set; }

        /// <summary>
        /// 初始化企业微信API客户端
        /// </summary>
        /// <param name="corpId">企业ID</param>
        /// <param name="corpSecret">应用的凭证密钥</param>
        public ApiClientBase(string corpId, string corpSecret)
        {
            CorpId = corpId;
            CorpSecret = corpSecret;
        }

        /// <summary>
        /// 初始化企业微信API客户端
        /// </summary>
        /// <param name="corpId">企业ID</param>
        /// <param name="agentId">企业应用的ID</param>
        /// <param name="corpSecret">应用的凭证密钥</param>
        public ApiClientBase(string corpId, int agentId, string corpSecret)
        {
            CorpId = corpId;
            AgentId = agentId;
            CorpSecret = corpSecret;
        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        public AccessTokenResult GetToken()
        {
            if (AccessTokenResult == null || AccessTokenResult.ExpireTime <= DateTime.Now)
            {
                var result = GetAsJson<AccessTokenResult>("/gettoken", new {corpid = CorpId, corpsecret = CorpSecret});
                return result;
            }
            else
            {
                return AccessTokenResult;
            }
        }

        /// <summary>
        /// 获取JsApi凭证
        /// </summary>
        public JsApiTicketResult GetJsApiTicket()
        {
            if (JsApiTicketResult == null || JsApiTicketResult.ExpireTime <= DateTime.Now)
            {
                var accessToken = GetToken();
                var result = GetAsJson<JsApiTicketResult>("/get_jsapi_ticket", new {accessToken.access_token});
                return result;
            }
            else
            {
                return JsApiTicketResult;
            }
        }

        /// <summary>
        /// 创建JSSDK信息包
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public JsSdkUiPackage GetJsSdkUiPackage(string url)
        {
            var jsApiTicket = GetJsApiTicket();
            var nonceStr = JSSDKHelper.GetNoncestr();
            var timestamp = JSSDKHelper.GetTimestamp();
            var signature = JSSDKHelper.GetSignature(jsApiTicket.ticket, nonceStr, timestamp, url);
            return new JsSdkUiPackage(appId: CorpId, timestamp: timestamp.ToString(), nonceStr: nonceStr,
                signature: signature);
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
            string returnText = Send(url, queryObj, null, HttpMethod.GET);

            if (returnText.Contains("errcode"))
            {
                //可能发生错误
                JsonResult errorResult = JsonConvert.DeserializeObject<JsonResult>(returnText);
                if (errorResult.errcode != ReturnCode.请求成功)
                {
                    //发生错误
                    if (ApiError != null)
                    {
                        var msg = string.Format("企业微信接口请求返回错误，err：{0}，request：{1}",
                            JsonConvert.SerializeObject(new
                            {
                                errorResult.errcode,
                                errtxt = errorResult.errcode.ToString(),
                                errorResult.errmsg
                            }),
                            JsonConvert.SerializeObject(new
                            {
                                Method = HttpMethod.GET.ToString(),
                                Url = url,
                                Query = queryObj,
                            }));
                        ApiError(new Exception(msg));
                    }
                }
            }

            T result = JsonConvert.DeserializeObject<T>(returnText);

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
            string returnText = Send(url, queryObj, bodyObj, HttpMethod.POST);

            if (returnText.Contains("errcode"))
            {
                //可能发生错误
                JsonResult errorResult = JsonConvert.DeserializeObject<JsonResult>(returnText);
                if (errorResult.errcode != ReturnCode.请求成功)
                {
                    //发生错误
                    if (ApiError != null)
                    {
                        var msg = string.Format("企业微信接口请求返回错误，err：{0}，request：{1}",
                            JsonConvert.SerializeObject(new
                            {
                                errorResult.errcode,
                                errtxt = errorResult.errcode.ToString(),
                                errorResult.errmsg
                            }),
                            JsonConvert.SerializeObject(new
                            {
                                Method = HttpMethod.POST.ToString(),
                                Url = url,
                                Query = queryObj,
                                Body = bodyObj
                            }));
                        ApiError(new Exception(msg));
                    }
                }
            }

            T result = JsonConvert.DeserializeObject<T>(returnText);

            return result;
        }
    }
}
