using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.qrcode
{
    public class QRCodeUtility
    {
        public static void GenerateAndSaveQRCode(string url, string folderPath)
        {
            // Kiểm tra xem thư mục đã tồn tại chưa, nếu chưa thì tạo mới
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = "qrCodeImage" + DateTime.Now.Millisecond + ".png"; // Bạn có thể tùy chỉnh tên file dựa trên yêu cầu
            string pathToSaveImage = Path.Combine(folderPath, fileName);

            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(qrCodeData))
                {
                    using (var qrCodeImage = qrCode.GetGraphic(20))
                    {
                        qrCodeImage.Save(pathToSaveImage, ImageFormat.Png);
                    }
                }
            }
        }
        public static string GenerateAndSaveQRCode1(string url, string folderPath)
        {
            // Kiểm tra xem thư mục đã tồn tại chưa, nếu chưa thì tạo mới
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = "qrCodeImage1+" + DateTime.Now + ".png"; // Bạn có thể tùy chỉnh tên file dựa trên yêu cầu
            string pathToSaveImage = Path.Combine(folderPath, fileName);

            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                using (var qrCode = new QRCode(qrCodeData))
                {
                    using (var qrCodeImage = qrCode.GetGraphic(20))
                    {
                        qrCodeImage.Save(pathToSaveImage, ImageFormat.Png);
                    }
                }
            }
            return pathToSaveImage;
        }
    }
}