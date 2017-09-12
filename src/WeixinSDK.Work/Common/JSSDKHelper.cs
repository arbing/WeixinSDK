﻿using System;
using System.Text;

namespace WeixinSDK.Work.Common
{
    public class JSSDKHelper
    {
        /// <summary>
        /// 获取随机字符串
        /// </summary>
        /// <returns></returns>
        public static string GetNoncestr()
        {
            return EncryptHelper.GetMD5(Guid.NewGuid().ToString(), Encoding.UTF8);
        }

        /// <summary>
        /// 获取时间戳
        /// <remarks>
        /// 2016-05-03：修改返回类型，方便GetSignature调用，避免再次类型转换
        /// </remarks>
        /// </summary>
        /// <returns></returns>
        public static long GetTimestamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }

        /// <summary>
        /// 获取JS-SDK权限验证的签名Signature
        /// </summary>
        /// <param name="jsapi_ticket">jsapi_ticket</param>
        /// <param name="noncestr">随机字符串(必须与wx.config中的nonceStr相同)</param>
        /// <param name="timestamp">时间戳(必须与wx.config中的timestamp相同)</param>
        /// <param name="url">当前网页的URL，不包含#及其后面部分(必须是调用JS接口页面的完整URL)</param>
        /// <returns></returns>
        public static string GetSignature(string jsapi_ticket, string noncestr, long timestamp, string url)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("jsapi_ticket=").Append(jsapi_ticket).Append("&")
                .Append("noncestr=").Append(noncestr).Append("&")
                .Append("timestamp=").Append(timestamp).Append("&")
                .Append("url=").Append(url.IndexOf("#") >= 0 ? url.Substring(0, url.IndexOf("#")) : url);
            return EncryptHelper.GetSha1(sb.ToString()).ToLower();
        }
    }
}
