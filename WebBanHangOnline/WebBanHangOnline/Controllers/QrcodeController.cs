using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using WebBanHangOnline.qrcode;

namespace WebBanHangOnline.Controllers
{
    public class QRCodeController : Controller
    {
        /*public ActionResult Generate(string text)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    using (Bitmap bitmap = qrCode.GetGraphic(20))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] byteImage = ms.ToArray();
                            return File(byteImage, "image/png");
                        }
                    }
                }
            }
        }
    }*/
        [HttpGet]
        public void Test()
        {
            string url = "https://192.168.137.1:44314/chi-tiet/fujifilm-x100t-16-mp-digital-camera-(silver)-p6";
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}/Common/Imageqrcode";
            QRCodeUtility.GenerateAndSaveQRCode(url, path);
        }
        
    }
}