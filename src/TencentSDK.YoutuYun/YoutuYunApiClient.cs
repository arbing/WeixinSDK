using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentSDK.YoutuYun.Apis;
using TencentSDK.YoutuYun.Common;

namespace TencentSDK.YoutuYun
{
    /// <summary>
    /// 腾讯优图API客户端类
    /// </summary>
    public class YoutuYunApiClient : ApiClientBase
    {
        /// <summary>
        /// 成员管理接口
        /// </summary>
        public OcrApi Ocr { get; private set; }

        /// <summary>
        /// 初始化腾讯优图API客户端
        /// </summary>
        /// <param name="appId">应用的AppId</param>
        /// <param name="secretId">应用的SecretID</param>
        /// <param name="secretKey">应用的SecretKey</param>
        /// <param name="userId">应用的UserId</param>
        public YoutuYunApiClient(string appId, string secretId, string secretKey, string userId) : base(appId, secretId, secretKey, userId)
        {
            Initialize();
        }


        /// <summary>
        /// 初始化API Client属性
        /// </summary>
        private void Initialize()
        {
            if (string.IsNullOrEmpty(BaseUrl))
            {
                throw new ArgumentNullException("BaseUrl");
            }

            if (string.IsNullOrEmpty(AppId))
            {
                throw new ArgumentNullException("AppId");
            }

            if (string.IsNullOrEmpty(SecretId))
            {
                throw new ArgumentNullException("SecretId");
            }

            if (string.IsNullOrEmpty(SecretKey))
            {
                throw new ArgumentNullException("SecretKey");
            }

            if (string.IsNullOrEmpty(UserId))
            {
                throw new ArgumentNullException("UserId");
            }

            Ocr = new OcrApi(this);
        }
    }
}
