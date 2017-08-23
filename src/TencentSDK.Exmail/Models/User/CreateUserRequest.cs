using System.Collections.Generic;

namespace TencentSDK.Exmail.Models.User
{
    /// <summary>
    /// 创建成员请求参数类
    /// </summary>
    public class CreateUserRequest
    {
        /// <summary>
        /// 成员UserID。企业邮帐号名，邮箱格式。必填
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 成员名称。长度为1~64个字节。必填
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 成员所属部门id列表，不超过20个。必填
        /// </summary>
        public List<long> department { get; set; }

        /// <summary>
        /// 职位信息。长度为0~64个字节
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 座机号码。
        /// </summary>
        public string tel { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string extid { get; set; }

        /// <summary>
        /// 性别。1表示男性，2表示女性
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// 别名列表 1.Slaves 上限为5个 2.Slaves 为邮箱格式
        /// </summary>
        public List<string> slaves { get; set; }

        /// <summary>
        /// 密码。必填
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 用户重新登录时是否重设密码, 登陆重设密码后，该标志位还原。0表示否，1表示是，缺省为0
        /// </summary>
        public int cpwd_login { get; set; }
    }
}
