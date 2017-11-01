using System;
using WeixinSDK.Work.Apis;
using WeixinSDK.Work.Common;

namespace WeixinSDK.Work
{
    /// <summary>
    /// 企业微信API客户端类
    /// </summary>
    public class WeixinWorkApiClient : ApiClientBase
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
        /// 标签管理接口
        /// </summary>
        public TagApi Tag { get; private set; }

        /// <summary>
        /// 打卡数据接口
        /// </summary>
        public CheckInApi CheckIn { get; private set; }

        /// <summary>
        /// 消息推送接口
        /// </summary>
        public MessageApi Message { get; private set; }

        /// <summary>
        /// 应用管理接口
        /// </summary>
        public AgentApi Agent { get; private set; }

        /// <summary>
        /// 初始化企业微信API客户端
        /// </summary>
        /// <param name="corpId">企业ID</param>
        /// <param name="corpSecret">应用的凭证密钥</param>
        public WeixinWorkApiClient(string corpId, string corpSecret):base(corpId, corpSecret)
        {
            Initialize();
        }

        /// <summary>
        /// 初始化企业微信API客户端
        /// </summary>
        /// <param name="corpId">企业ID</param>
        /// <param name="agentId">企业应用的ID</param>
        /// <param name="corpSecret">应用的凭证密钥</param>
        public WeixinWorkApiClient(string corpId, int agentId, string corpSecret) : base(corpId, agentId, corpSecret)
        {
            Initialize();

            if (AgentId <= 0)
            {
                throw new ArgumentNullException("AgentId");
            }
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
            Tag = new TagApi(this);
            CheckIn = new CheckInApi(this);
            Message = new MessageApi(this);
            Agent = new AgentApi(this);
        }
    }
}
