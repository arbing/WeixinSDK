using System;
using TencentSDK.YoutuYun.Common;

namespace TencentSDK.YoutuYun.Models.Common
{
    /// <summary>
    /// 鉴权签名串
    /// </summary>
    public class AuthorizationResult
    {
        /// <summary>
        /// 签名串
        /// </summary>
        public string SignStr { get; set; }

        /// <summary>
        /// 凭证过期时间
        /// </summary>
        public DateTime ExpireTime { get; set; }
    }
}
