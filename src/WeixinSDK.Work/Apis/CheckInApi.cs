using WeixinSDK.Work.Common;
using WeixinSDK.Work.Models.CheckIn;

namespace WeixinSDK.Work.Apis
{
    /// <summary>
    /// 打卡数据接口
    /// </summary>
    public class CheckInApi : ApiBase
    {
        /// <summary>
        /// 实例化打卡数据接口
        /// </summary>
        /// <param name="client"></param>
        public CheckInApi(ApiClientBase client) : base(client)
        {
        }

        /// <summary>
        /// 获取打卡数据
        /// 文档：https://work.weixin.qq.com/api/doc#11196
        /// </summary>
        /// <param name="data">请求参数</param>
        /// <returns>返回结果</returns>
        public GetCheckInDataResult GetCheckInData(GetCheckInDataRequest data)
        {
            // 获取记录时间跨度不超过三个月
            // 用户列表不超过100个。若用户超过100个，请分批获取
            // 有打卡记录即可获取打卡数据，与当前”打卡应用”是否开启无关

            var accessToken = Client.GetToken();
            return Client.PostAsJson<GetCheckInDataResult>("/checkin/getcheckindata", new { accessToken.access_token}, data);
        }
    }
}
