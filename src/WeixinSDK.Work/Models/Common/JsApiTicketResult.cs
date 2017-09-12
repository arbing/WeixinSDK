using System;

namespace WeixinSDK.Work.Models.Common
{
    /// <summary>
    /// jsapi_ticket请求后的JSON返回格式
    /// </summary>
    public class JsApiTicketResult : JsonResult
    {
        /// <summary>
        /// 获取到的凭证
        /// </summary>
        public string ticket { get; set; }

        /// <summary>
        /// 凭证的有效时间（秒）
        /// </summary>
        public int expires_in { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpireTime
        {
            get { return GetExpireTime(expires_in); }
        }

        /// <summary>
        /// 获取过期时间
        /// </summary>
        /// <param name="expireInSeconds">有效时间（秒）</param>
        /// <returns></returns>
        public static DateTime GetExpireTime(int expireInSeconds)
        {
            if (expireInSeconds > 3600)
            {
                expireInSeconds -= 600;//提前10分钟过期
            }
            else if (expireInSeconds > 1800)
            {
                expireInSeconds -= 300;//提前5分钟过期
            }
            else if (expireInSeconds > 300)
            {
                expireInSeconds -= 30;//提前1分钟过期
            }

            return DateTime.Now.AddSeconds(expireInSeconds);//提前2分钟重新获取
        }
    }
}
