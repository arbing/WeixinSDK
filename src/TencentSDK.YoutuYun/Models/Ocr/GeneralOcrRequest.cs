using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TencentSDK.YoutuYun.Models.Ocr
{
    /// <summary>
    /// 通用OCR识别的请求参数类
    /// </summary>
    public class GeneralOcrRequest
    {
        /// <summary>
        /// 需要检测的图像本地路径，图像需要是JPG PNG BMP 其中之一的格式, 可选
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// 需要检测的图像base64编码，图像需要是JPG PNG BMP 其中之一的格式, 可选
        /// </summary>
        public string image { get; set; }

        /// <summary>
        /// 图片可以下载的url, 如果url 和image 都提供, 仅使用url, 可选
        /// </summary>
        public string url { get; set; }
    }
}
