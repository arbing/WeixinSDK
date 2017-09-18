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
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">文本内容</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendText(SendMessageParam recipient, TextMessageInfo message)
        {
            var request = new SendTextRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.text = message;
            return Send(request);
        }

        /// <summary>
        /// 发送图片消息
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">图片媒体文件</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendImage(SendMessageParam recipient, MediaMessageInfo message)
        {
            var request = new SendImageRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.image = message;
            return Send(request);
        }

        /// <summary>
        /// 发送语音消息
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">语音媒体文件</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendVoice(SendMessageParam recipient, MediaMessageInfo message)
        {
            var request = new SendVoiceRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.voice = message;
            return Send(request);
        }

        /// <summary>
        /// 发送视频消息
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">视频媒体文件</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendVideo(SendMessageParam recipient, VideoMessageInfo message)
        {
            var request = new SendVideoRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.video = message;
            return Send(request);
        }

        /// <summary>
        /// 发送文件消息
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">文件媒体文件</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendFile(SendMessageParam recipient, MediaMessageInfo message)
        {
            var request = new SendFileRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.file = message;
            return Send(request);
        }

        /// <summary>
        /// 发送文本卡片消息
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">文本卡片消息</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendTextCard(SendMessageParam recipient, TextCardMessageInfo message)
        {
            var request = new SendTextCardRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.textcard = message;
            return Send(request);
        }

        /// <summary>
        /// 发送图文消息
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">图文消息</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendNews(SendMessageParam recipient, NewsMessageInfo message)
        {
            var request = new SendNewsRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.news = message;
            return Send(request);
        }

        /// <summary>
        /// 发送图文消息（mpnews）
        /// </summary>
        /// <param name="recipient">接收者参数</param>
        /// <param name="message">图文消息（mpnews）</param>
        /// <returns>返回结果</returns>
        public SendMessageResult SendMpNews(SendMessageParam recipient, MpNewsMessageInfo message)
        {
            var request = new SendMpNewsRequest(recipient.ToRequest());
            request.agentid = Client.AgentId;
            request.mpnews = message;
            return Send(request);
        }

        /// <summary>
        /// 发送文本、图片、视频、文件、图文等类型消息
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
