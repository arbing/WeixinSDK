using System.Collections.Generic;
using WeixinSDK.Work.Models.Common;

namespace WeixinSDK.Work.Models.CheckIn
{
    /// <summary>
    /// 获取打卡数据的返回结果类
    /// </summary>
    public class GetCheckInDataResult : JsonResult
    {
        /// <summary>
        /// 打卡数据列表
        /// </summary>
        public List<GetCheckInDataInfo> checkindata { get; set; }
    }
}
