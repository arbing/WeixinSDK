using System;
using TencentSDK.Exmail.Apis;
using TencentSDK.Exmail.Common;

namespace TencentSDK.Exmail
{
    /// <summary>
    /// 腾讯企业邮箱API客户端类
    /// </summary>
    public class TencentExmailApiClient : ApiClientBase
    {
        /// <summary>
        /// 成员管理接口
        /// </summary>
        public UserApi User { get; private set; }

        /// <summary>
        /// 部门管理接口
        /// </summary>
        public DepartmentApi Department { get; private set; }

        /// <summary>
        /// 初始化腾讯企业邮箱API客户端
        /// </summary>
        /// <param name="corpId">企业ID</param>
        /// <param name="corpSecret">应用的凭证密钥</param>
        public TencentExmailApiClient(string corpId, string corpSecret):base(corpId, corpSecret)
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

            if (string.IsNullOrEmpty(CorpId))
            {
                throw new ArgumentNullException("CorpId");
            }

            if (string.IsNullOrEmpty(CorpSecret))
            {
                throw new ArgumentNullException("CorpSecret");
            }

            User = new UserApi(this);
            Department = new DepartmentApi(this);
        }
    }
}
