using System.Collections.Generic;

namespace WeixinSDK.Work.Models.CheckIn
{
    /// <summary>
    /// 获取打卡数据请求参数类
    /// </summary>
    public class GetCheckInDataRequest
    {
        /// <summary>
        /// 打卡类型。1：上下班打卡；2：外出打卡；3：全部打卡。必填
        /// </summary>
        public int opencheckindatatype { get; set; }

        /// <summary>
        /// 获取打卡记录的开始时间。UTC时间戳。必填
        /// </summary>
        public long starttime { get; set; }

        /// <summary>
        /// 获取打卡记录的结束时间。UTC时间戳。必填
        /// </summary>
        public long endtime { get; set; }

        /// <summary>
        /// 需要获取打卡记录的用户列表。必填
        /// </summary>
        public List<string> useridlist { get; set; }
    }
}
