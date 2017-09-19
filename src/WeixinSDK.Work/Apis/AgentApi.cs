using WeixinSDK.Work.Common;
using WeixinSDK.Work.Models.Agent;

namespace WeixinSDK.Work.Apis
{
    /// <summary>
    /// 应用管理接口
    /// </summary>
    public class AgentApi : ApiBase
    {
        /// <summary>
        /// 实例化应用管理接口
        /// </summary>
        /// <param name="client"></param>
        public AgentApi(ApiClientBase client) : base(client)
        {
        }


        /// <summary>
        /// 获取应用
        /// 文档：https://work.weixin.qq.com/api/doc#10087
        /// </summary>
        /// <param name="agentid">授权方应用id</param>
        /// <returns>返回结果</returns>
        public GetAgentResult Get(int agentid)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<GetAgentResult>("/agent/get", new { accessToken.access_token, agentid });
        }
    }
}
