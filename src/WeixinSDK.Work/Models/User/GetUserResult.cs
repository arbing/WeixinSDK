using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.User
{
    /// <summary>
    /// 获取成员详情的返回结果类
    /// </summary>
    public class GetUserResult : JsonResult
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
        /// 手机号码，第三方仅通讯录套件可获取
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 成员所属部门id列表
        /// </summary>
        public List<int> department { get; set; }

        /// <summary>
        /// 部门内的排序值，默认为0。数量必须和department一致，数值越大排序越前面。值范围是[0, 2^32)
        /// </summary>
        public List<int> order { get; set; }

        /// <summary>
        /// 职位信息
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 性别。0表示未定义，1表示男性，2表示女性
        /// </summary>
        public int gender { get; set; }

        /// <summary>
        /// 邮箱，第三方仅通讯录套件可获取
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 上级字段，标识是否为上级。
        /// </summary>
        public int isleader { get; set; }

        /// <summary>
        /// 头像url。注：如果要获取小图将url最后的”/0”改成”/100”即可
        /// </summary>
        public string avatar { get; set; }

        /// <summary>
        /// 座机。第三方仅通讯录套件可获取
        /// </summary>
        public string telephone { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string english_name { get; set; }

        /// <summary>
        /// 扩展属性，第三方仅通讯录套件可获取
        /// </summary>
        public Extattr extattr { get; set; }

        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        public int enable { get; set; }

        /// <summary>
        /// 激活状态: 1=已激活，2=已禁用，4=未激活 已激活代表已激活企业微信或已关注微信插件。未激活代表既未激活企业微信又未关注微信插件。
        /// </summary>
        public int status { get; set; }
    }

    /// <summary>
    /// 成员扩展属性类
    /// </summary>
    public class Extattr
    {
        /// <summary>
        /// 扩展属性列表
        /// </summary>
        public List<Attr> attrs { get; set; }
    }

    /// <summary>
    /// 属性类
    /// </summary>
    public class Attr
    {
        /// <summary>
        /// 属性名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string value { get; set; }
    }
}
