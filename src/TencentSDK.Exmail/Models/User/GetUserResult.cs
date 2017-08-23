using System.Collections.Generic;
using TencentSDK.Exmail.Models.Common;

namespace TencentSDK.Exmail.Models.User
{
    /// <summary>
    /// 获取成员详情的返回结果类
    /// </summary>
    public class GetUserResult : JsonResult
    {
        /// <summary>
        /// 成员UserID。企业邮帐号名，邮箱格式
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 成员名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 成员所属部门id列表
        /// </summary>
        public List<long> department { get; set; }

        /// <summary>
        /// 职位信息
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 座机号码
        /// </summary>
        public string tel { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string extid { get; set; }

        /// <summary>
        /// 性别。0表示未定义，1表示男性，2表示女性
        /// </summary>
        public int gender { get; set; }
        
        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        public int enable { get; set; }

        /// <summary>
        /// 别名列表 1.Slaves 上限为5个 2.Slaves 为邮箱格式
        /// </summary>
        public List<string> slaves { get; set; }

        /// <summary>
        /// 用户重新登录时是否重设密码, 登陆重设密码后，该标志位还原。0表示否，1表示是，缺省为0
        /// </summary>
        public int cpwd_login { get; set; }
    }
}
