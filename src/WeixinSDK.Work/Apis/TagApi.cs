using WeixinSDK.Work.Common;
using WeixinSDK.Work.Models.Common;
using WeixinSDK.Work.Models.Tag;

namespace WeixinSDK.Work.Apis
{
    /// <summary>
    /// 标签管理接口
    /// </summary>
    public class TagApi : ApiBase
    {
        /// <summary>
        /// 实例化标签管理接口
        /// </summary>
        /// <param name="client"></param>
        public TagApi(ApiClientBase client) : base(client)
        {
        }

        /// <summary>
        /// 创建标签
        /// 文档：https://work.weixin.qq.com/api/doc#10915
        /// </summary>
        /// <param name="tag">标签信息</param>
        /// <returns>返回结果</returns>
        public CreateTagResult Create(CreateTagRequest tag)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<CreateTagResult>("/tag/create", new { accessToken.access_token }, tag);
        }

        /// <summary>
        /// 更新标签名字
        /// 文档：https://work.weixin.qq.com/api/doc#10919
        /// </summary>
        /// <param name="tag">标签信息</param>
        /// <returns>返回结果</returns>
        public JsonResult Update(UpdateTagRequest tag)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/tag/update", new { accessToken.access_token }, tag);
        }

        /// <summary>
        /// 删除标签
        /// 文档：https://work.weixin.qq.com/api/doc#10920
        /// </summary>
        /// <param name="tagid">标签ID</param>
        /// <returns>返回结果</returns>
        public JsonResult Delete(int tagid)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<JsonResult>("/tag/delete", new { accessToken.access_token, tagid }, null);
        }

        /// <summary>
        /// 获取标签成员
        /// 文档：https://work.weixin.qq.com/api/doc#10921
        /// </summary>
        /// <param name="tagid">标签ID</param>
        /// <returns>返回结果</returns>
        public GetTagResult Get(int tagid)
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<GetTagResult>("/tag/get", new { accessToken.access_token, tagid });
        }

        /// <summary>
        /// 增加标签成员
        /// 文档：https://work.weixin.qq.com/api/doc#10923
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public AddTagUsersResult AddTagUsers(AddTagUsersRequest request)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<AddTagUsersResult>("/tag/addtagusers", new { accessToken.access_token }, request);
        }

        /// <summary>
        /// 删除标签成员
        /// 文档：https://work.weixin.qq.com/api/doc#10925
        /// </summary>
        /// <param name="request">请求参数</param>
        /// <returns>返回结果</returns>
        public DelTagUsersResult DelTagUsers(DelTagUsersRequest request)
        {
            var accessToken = Client.GetToken();
            return Client.PostAsJson<DelTagUsersResult>("/tag/deltagusers", new { accessToken.access_token }, request);
        }


        /// <summary>
        /// 获取标签列表
        /// 文档：https://work.weixin.qq.com/api/doc#10926
        /// </summary>
        /// <returns>返回结果</returns>
        public ListTagResult List()
        {
            var accessToken = Client.GetToken();
            return Client.GetAsJson<ListTagResult>("/tag/list", new { accessToken.access_token });
        }
    }
}
