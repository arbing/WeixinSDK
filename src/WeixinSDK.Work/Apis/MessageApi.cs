using WeixinSDK.Work.Common;
using WeixinSDK.Work.Models.Message;

namespace WeixinSDK.Work.Apis
{
    /// <summary>
    /// 消息发送接口
    /// </summary>
    public class MessageApi : ApiBase
    {
        /// <summary>
        /// 实例化消息发送接口
        /// </summary>
        /// <param name="client"></param>
        public MessageApi(ApiClientBase client) : base(client)
        {
        }

        /// <summary>
        /// 发送文本消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendText(SendTextRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }

            return Send(request);
        }

        /// <summary>
        /// 发送图片消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendImage(SendImageRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送语音消息
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendVoice(SendVoiceRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送视频消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendVideo(SendVideoRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送文件消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendFile(SendFileRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送文本卡片消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendTextCard(SendTextCardRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送图文消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendNews(SendNewsRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送图文消息（mpnews）
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendMpNews(SendMpNewsRequest request)
        {
            if (request.agentid == 0)
            {
                request.agentid = Client.AgentId;
            }
            return Send(request);
        }

        /// <summary>
        /// 发送文本、图片、视频、文件、图文等类型消息
        /// 文档：https://work.weixin.qq.com/api/doc#10167
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public SendMessageResult Send(SendMessageRequest request)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<SendMessageResult>("/message/send", new {accessToken.access_token},
                request);
        }
    }
}
