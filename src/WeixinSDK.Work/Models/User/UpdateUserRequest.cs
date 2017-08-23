using System.Collections.Generic;

namespace WeixinSDK.Work.Models.User
{
    /// <summary>
    /// 更新成员请求参数类
    /// </summary>
    public class UpdateUserRequest
    {
        /// <summary>
        /// 成员UserID。对应管理端的帐号，企业内必须唯一。不区分大小写，长度为1~64个字节。必填
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 成员名称。长度为1~64个字节。
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 英文名。长度为1-64个字节。
        /// </summary>
        public string english_name { get; set; }

        /// <summary>
        /// 手机号码。企业内必须唯一。
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 成员所属部门id列表,不超过20个。
        /// </summary>
        public List<int> department { get; set; }

        /// <summary>
        /// 部门内的排序值，默认为0。数量必须和department一致，数值越大排序越前面。有效的值范围是[0, 2^32)
        /// </summary>
        public List<int> order { get; set; }


        /// <summary>
        /// 职位信息。长度为0~64个字节
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 性别。1表示男性，2表示女性
        /// </summary>
        public int? gender { get; set; }

        /// <summary>
        /// 邮箱。长度为0~64个字节。企业内必须唯一
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 座机。长度0-64个字节。
        /// </summary>
        public string telephone { get; set; }

        /// <summary>
        /// 上级字段，标识是否为上级。
        /// </summary>
        public int? isleader { get; set; }

        /// <summary>
        /// 成员头像的mediaid，通过多媒体接口上传图片获得的mediaid
        /// </summary>
        public string avatar_mediaid { get; set; }

        /// <summary>
        /// 启用/禁用成员。1表示启用成员，0表示禁用成员
        /// </summary>
        public int? enable { get; set; }

        /// <summary>
        /// 自定义字段。自定义字段需要先在WEB管理端“我的企业” — “通讯录管理”添加，否则忽略未知属性的赋值
        /// </summary>
        public Extattr extattr { get; set; }
    }
}
