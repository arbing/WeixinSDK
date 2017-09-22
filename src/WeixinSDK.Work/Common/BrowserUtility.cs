using System.Web;

namespace WeixinSDK.Work.Common
{
    /// <summary>
    /// 浏览器公共类
    /// </summary>
    public static class BrowserUtility
    {
        /// <summary>
        /// 判断是否在微信内置浏览器中
        /// </summary>
        /// <param name="httpContext">HttpContextBase对象</param>
        /// <returns>true：在微信内置浏览器内。false：不在微信内置浏览器内。</returns>
        public static bool SideInWeixinBrowser(this HttpContextBase httpContext)
        {
            var userAgent = httpContext.Request.UserAgent;
            if (userAgent != null
                && (userAgent.Contains("MicroMessenger") || userAgent.Contains("Windows Phone")))
            {
                return true;//在微信内部
            }
            else
            {
                return false;//在微信外部
            }
        }
    }
}
