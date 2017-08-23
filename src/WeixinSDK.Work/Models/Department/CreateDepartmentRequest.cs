﻿namespace WeixinSDK.Work.Models.Department
{
    /// <summary>
    /// 创建部门请求参数类
    /// </summary>
    public class CreateDepartmentRequest
    {
        /// <summary>
        /// 部门名称。长度限制为1~64个字节，字符不能包括\:?”&lt;&gt;｜。必填
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 父部门id。必填
        /// </summary>
        public int parentid { get; set; }

        /// <summary>
        /// 在父部门中的次序值。order值大的排序靠前。有效的值范围是[0, 2^32)
        /// </summary>
        public uint order { get; set; }

        /// <summary>
        /// 部门id，整型。指定时必须大于1，否则自动生成
        /// </summary>
        public int id { get; set; }
    }
}
