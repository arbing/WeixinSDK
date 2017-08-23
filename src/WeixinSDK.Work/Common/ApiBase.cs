using System;

namespace WeixinSDK.Work.Common
{
    /// <summary>
    /// API操作基类
    /// </summary>
    public class ApiBase
    {
        /// <summary>
        /// 初始化Api实例
        /// </summary>
        /// <param name="client">ApiClient引用</param>
        public ApiBase(ApiClientBase client)
        {
            if (client == null)
            {
                throw new ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// ApiClient引用
        /// </summary>
        public ApiClientBase Client { get; private set; }
    }
}
