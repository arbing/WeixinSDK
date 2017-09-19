using System.Collections.Generic;
using Newtonsoft.Json;
using WeixinSDK.Work.Common;

namespace WeixinSDK.Work.Models.Message
{
    /// <summary>
    /// 发送消息请求参数类
    /// </summary>
    public class SendMessageRequest
    {
        /// <summary>
        /// 成员ID列表（消息接收者，多个接收者用‘|’分隔，最多支持1000个）。特殊情况：指定为@all，则向该企业应用的全部成员发送。
        /// </summary>
        [JsonIgnore]
        public IList<string> UserIds { get; set; }

        /// <summary>
        /// 部门ID列表，多个接收者用‘|’分隔，最多支持100个。当touser为@all时忽略本参数
        /// </summary>
        [JsonIgnore]
        public IList<long> PartyIds { get; set; }

        /// <summary>
        /// 标签ID列表，多个接收者用‘|’分隔，最多支持100个。当touser为@all时忽略本参数
        /// </summary>
        [JsonIgnore]
        public IList<long> TagIds { get; set; }

        /// <summary>
        /// 表示是否是保密消息
        /// </summary>
        [JsonIgnore]
        public bool IsSafe { get; set; }

        /// <summary>
        /// 成员ID列表（消息接收者，多个接收者用‘|’分隔，最多支持1000个）。特殊情况：指定为@all，则向该企业应用的全部成员发送。
        /// </summary>
        public string touser { get { return UserIds.ToIds(); } }

        /// <summary>
        /// 部门ID列表，多个接收者用‘|’分隔，最多支持100个。当touser为@all时忽略本参数
        /// </summary>
        public string toparty { get { return PartyIds.ToIds(); } }

        /// <summary>
        /// 标签ID列表，多个接收者用‘|’分隔，最多支持100个。当touser为@all时忽略本参数
        /// </summary>
        public string totag { get { return TagIds.ToIds(); } }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype { get; set; }

        /// <summary>
        /// 企业应用的id，整型。可在应用的设置页面查看。必填
        /// </summary>
        public int agentid { get; set; }

        /// <summary>
        /// 表示是否是保密消息，0表示否，1表示是，默认0
        /// </summary>
        public int safe { get { return IsSafe ? 1 : 0; } }
    }

    /// <summary>
    /// 发送文本消息请求参数类
    /// </summary>
    public class SendTextRequest : SendMessageRequest
    {
        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "text"; }
        }

        /// <summary>
        /// 文本消息。必填
        /// </summary>
        public TextMessageInfo text { get; set; }
    }

    /// <summary>
    /// 文本消息类
    /// </summary>
    public class TextMessageInfo
    {
        /// <summary>
        /// 消息内容，最长不超过2048个字节。必填。可以支持换行、以及A标签，即可打开自定义的网页（可参考以上示例代码）(注意：换行符请用转义过的\n)
        /// </summary>
        public string content { get; set; }
    }

    /// <summary>
    /// 发送图片消息请求参数类
    /// </summary>
    public class SendImageRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendImageRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "image"; }
        }

        /// <summary>
        /// 图片媒体文件。必填
        /// </summary>
        public MediaMessageInfo image { get; set; }
    }

    /// <summary>
    /// 媒体消息类
    /// </summary>
    public class MediaMessageInfo
    {
        /// <summary>
        /// 媒体文件id，可以调用上传临时素材接口获取。必填
        /// </summary>
        public string media_id { get; set; }
    }

    /// <summary>
    /// 发送语音消息请求参数类
    /// </summary>
    public class SendVoiceRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendVoiceRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "voice"; }
        }

        /// <summary>
        /// 语音媒体文件。必填
        /// </summary>
        public MediaMessageInfo voice { get; set; }
    }

    /// <summary>
    /// 发送视频消息请求参数类
    /// </summary>
    public class SendVideoRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendVideoRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "video"; }
        }

        /// <summary>
        /// 视频消息信息。必填
        /// </summary>
        public VideoMessageInfo video { get; set; }
    }

    /// <summary>
    /// 视频消息类
    /// </summary>
    public class VideoMessageInfo : MediaMessageInfo
    {
        /// <summary>
        /// 视频消息的标题，不超过128个字节，超过会自动截断
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 视频消息的描述，不超过512个字节，超过会自动截断
        /// </summary>
        public string description { get; set; }
    }

    /// <summary>
    /// 发送文件消息请求参数类
    /// </summary>
    public class SendFileRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendFileRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "file"; }
        }

        /// <summary>
        /// 文件媒体文件。必填
        /// </summary>
        public MediaMessageInfo file { get; set; }
    }

    /// <summary>
    /// 发送文本卡片消息请求参数类
    /// </summary>
    public class SendTextCardRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendTextCardRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "textcard"; }
        }

        /// <summary>
        /// 文本卡片消息。必填
        /// </summary>
        public TextCardMessageInfo textcard { get; set; }
    }

    /// <summary>
    /// 文本卡片消息类
    /// </summary>
    public class TextCardMessageInfo
    {
        /// <summary>
        /// 标题，不超过128个字节，超过会自动截断。必填
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 描述，不超过512个字节，超过会自动截断。必填
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 点击后跳转的链接。必填
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 按钮文字。 默认为“详情”， 不超过4个文字，超过自动截断。
        /// </summary>
        public string btntxt { get; set; }
    }

    /// <summary>
    /// 发送图文消息请求参数类
    /// </summary>
    public class SendNewsRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendNewsRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "news"; }
        }

        /// <summary>
        /// 图文消息。必填
        /// </summary>
        public NewsMessageInfo news { get; set; }
    }

    /// <summary>
    /// 图文消息类
    /// </summary>
    public class NewsMessageInfo
    {
        /// <summary>
        /// 图文消息，一个图文消息支持1到8条图文。必填
        /// </summary>
        public IList<ArticleMessageInfo> articles { get; set; }
    }

    /// <summary>
    /// 图文消息类
    /// </summary>
    public class ArticleMessageInfo
    {
        /// <summary>
        /// 标题，不超过128个字节，超过会自动截断。必填
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 描述，不超过512个字节，超过会自动截断
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 点击后跳转的链接。必填
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图640*320，小图80*80。
        /// </summary>
        public string picurl { get; set; }

        /// <summary>
        /// 按钮文字，仅在图文数为1条时才生效。 默认为“阅读全文”， 不超过4个文字，超过自动截断。该设置只在企业微信上生效，微信插件上不生效。
        /// </summary>
        public string btntxt { get; set; }
    }

    /// <summary>
    /// 发送图文消息（mpnews）请求参数类
    /// </summary>
    public class SendMpNewsRequest : SendMessageRequest
    {
        /// <summary>
        /// 初始化请求参数
        /// </summary>
        public SendMpNewsRequest()
        {
        }

        /// <summary>
        /// 消息类型。必填
        /// </summary>
        public string msgtype
        {
            get { return "mpnews"; }
        }

        /// <summary>
        /// 图文消息。必填
        /// </summary>
        public MpNewsMessageInfo mpnews { get; set; }
    }

    /// <summary>
    /// 图文消息（mpnews）类
    /// </summary>
    public class MpNewsMessageInfo
    {
        /// <summary>
        /// 图文消息，一个图文消息支持1到8条图文。必填
        /// </summary>
        public IList<MpArticleMessageInfo> articles { get; set; }
    }

    /// <summary>
    /// 图文消息（mpnews）类
    /// </summary>
    public class MpArticleMessageInfo
    {
        /// <summary>
        /// 标题，不超过128个字节，超过会自动截断。必填
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 图文消息缩略图的media_id, 可以在上传多媒体文件接口中获得。此处thumb_media_id即上传接口返回的media_id。必填
        /// </summary>
        public string thumb_media_id { get; set; }

        /// <summary>
        /// 图文消息的作者，不超过64个字节
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// 图文消息点击“阅读原文”之后的页面链接
        /// </summary>
        public string content_source_url { get; set; }

        /// <summary>
        /// 图文消息的内容，支持html标签，不超过666 K个字节。必填
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 图文消息的描述，不超过512个字节，超过会自动截断
        /// </summary>
        public string digest { get; set; }

        /// <summary>
        /// 表示是否是保密消息，0表示否，1表示是，默认0
        /// </summary>
        public int safe { get; set; }
    }
}
