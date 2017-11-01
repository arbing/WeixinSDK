using System.Collections.Generic;

namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 增加标签成员请求参数类
    /// </summary>
    public class AddTagUsersRequest
    {
        /// <summary>
        /// 标签ID。必填
        /// </summary>
        public int tagid { get; set; }

        /// <summary>
        /// 企业成员ID列表，注意：userlist、partylist不能同时为空，单次请求长度不超过1000
        /// </summary>
        public IList<string> userlist { get; set; }

        /// <summary>
        /// 企业部门ID列表，注意：userlist、partylist不能同时为空，单次请求长度不超过100
        /// </summary>
        public IList<int> partylist { get; set; }
    }
}
