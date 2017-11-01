namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 创建标签请求参数类
    /// </summary>
    public class CreateTagRequest
    {
        /// <summary>
        /// 标签名称，长度限制为32个字（汉字或英文字母），标签名不可与其他标签重名。必填
        /// </summary>
        public string tagname { get; set; }

        /// <summary>
        /// 标签id，非负整型，指定此参数时新增的标签会生成对应的标签id，不指定时则以目前最大的id自增。
        /// </summary>
        public int tagid { get; set; }
    }
}
