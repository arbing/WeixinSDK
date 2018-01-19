using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentSDK.YoutuYun.Common;
using TencentSDK.YoutuYun.Models.Common;
using TencentSDK.YoutuYun.Models.Ocr;

namespace TencentSDK.YoutuYun.Apis
{
    /// <summary>
    /// OCR识别API
    /// </summary>
    public class OcrApi : ApiBase
    {
        /// <summary>
        /// 初始化OCR识别API
        /// </summary>
        /// <param name="client"></param>
        public OcrApi(ApiClientBase client) : base(client)
        {
        }

        /// <summary>
        /// 通用OCR识别
        /// 根据用户上传的图像，返回识别出的字段信息
        /// 文档：http://open.youtu.qq.com/#/develop/api-ocr-general
        /// </summary>
        /// <param name="request">请求信息</param>
        /// <returns>返回结果</returns>
        public GeneralOcrResult GeneralOcr(GeneralOcrRequest request)
        {
            if (!string.IsNullOrEmpty(request.path) && string.IsNullOrEmpty(request.image))
            {
                request.image = ImageUtils.Base64FromFile(request.path);
            }

            return Client.PostAsJson<GeneralOcrResult>("/youtu/ocrapi/generalocr", null,
                new
                {
                    app_id = Client.AppId,
                    request.image,
                    request.url,
                });
        }
    }
}
