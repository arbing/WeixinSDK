using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace TencentSDK.YoutuYun.Common
{
    /// <summary>
    /// 图片工具方法类
    /// </summary>
    public class ImageUtils
    {
        /// <summary>
        /// 图片转Base64
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns>Base64</returns>
        public static string Base64FromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("文件不存在!");
            }

            var img = Image.FromFile(path);
            MemoryStream ms = new MemoryStream();
            string fileEtx = Path.GetExtension(path).ToLower();
            switch (fileEtx)
            {
                case ".jpg":
                    img.Save(ms, ImageFormat.Jpeg);
                    break;
                case ".png":
                    img.Save(ms, ImageFormat.Png);
                    break;
                case ".gif":
                    img.Save(ms, ImageFormat.Gif);
                    break;
                case ".bmp":
                    img.Save(ms, ImageFormat.Bmp);
                    break;
                default:
                    img.Save(ms, ImageFormat.Jpeg);
                    break;

            }
            return Convert.ToBase64String(ms.ToArray());
        }
    }
}
