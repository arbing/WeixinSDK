using System;
using System.Collections.Generic;
using WeixinSDK.Work.Common;

namespace WeixinSDK.Work.Models.CheckIn
{
    /// <summary>
    /// 获取打卡数据的返回打卡信息类
    /// </summary>
    public class GetCheckInDataInfo
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string userid { get; set; }

        /// <summary>
        /// 打卡规则名称
        /// </summary>
        public string groupname { get; set; }

        /// <summary>
        /// 打卡类型
        /// </summary>
        public string checkin_type { get; set; }

        /// <summary>
        /// 异常类型，如果有多个异常，以分号间隔
        /// </summary>
        public string exception_type { get; set; }

        /// <summary>
        /// 打卡时间。UTC时间戳
        /// </summary>
        public int checkin_time { get; set; }

        /// <summary>
        /// 打卡时间。本地时间
        /// </summary>
        public DateTime CheckinDateTime { get { return checkin_time.FromUnixTime(); } }

        /// <summary>
        /// 打卡地点title
        /// </summary>
        public string location_title { get; set; }

        /// <summary>
        /// 打卡地点详情
        /// </summary>
        public string location_detail { get; set; }

        /// <summary>
        /// 打卡wifi名称
        /// </summary>
        public string wifiname { get; set; }

        /// <summary>
        /// 打卡备注
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        /// 打卡的MAC地址/bssid
        /// </summary>
        public string wifimac { get; set; }

        /// <summary>
        /// 打卡的附件media_id，可使用media/get获取附件
        /// </summary>
        public List<string> mediaids { get; set; }
    }
}