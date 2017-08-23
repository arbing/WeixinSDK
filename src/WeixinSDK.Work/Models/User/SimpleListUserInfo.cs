using System.Collections.Generic;

namespace WeixinSDK.Work.Models.User
{
    /// <summary>
    /// 获取部门成员的返回成员信息类
    /// </summary>
    public class SimpleListUserInfo
    {
        /// <summary>
        /// 成员UserID。对应管理端的帐号
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 成员名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 成员所属部门
        /// </summary>
        public List<int> department { get; set; }
    }
}