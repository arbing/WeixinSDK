using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.Tag
{
    /// <summary>
    /// 获取标签成员的返回结果类
    /// </summary>
    public class GetTagResult : JsonResult
    {
        /// <summary>
        /// 标签名称
        /// </summary>
        public string tagname { get; set; }

        /// <summary>
        /// 标签成员列表
        /// </summary>
        public List<TagUserInfo> userlist { get; set; }

        /// <summary>
        /// 标签部门ID列表
        /// </summary>
        public List<int> partylist { get; set; }
    }
}
