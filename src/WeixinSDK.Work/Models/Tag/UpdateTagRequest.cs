namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 更新标签请求参数类
    /// </summary>
    public class UpdateTagRequest
    {
        /// <summary>
        /// 标签ID。必填
        /// </summary>
        public int tagid { get; set; }

        /// <summary>
        /// 标签名称，长度限制为32个字（汉字或英文字母），标签不可与其他标签重名。
        /// </summary>
        public string tagname { get; set; }
    }
}
