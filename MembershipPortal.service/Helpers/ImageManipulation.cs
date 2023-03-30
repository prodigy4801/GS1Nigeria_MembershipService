using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace MembershipPortal.service.Helpers
{
    public static class ImageManipulation
    {
        private static int MM_ISOTROPIC = 7;
        private static int MM_ANISOTROPIC = 8;

        public static string addWatermark(string x)
        {
            var img1 = Convert.FromBase64String(x);
            var s_img1 = new System.IO.MemoryStream(img1, 0, img1.Length);
            var img = Image.FromStream(s_img1);
            string watermarkText = "GS1 Nigeria Limited";
            string b64 = "";
            using (Graphics grp = Graphics.FromImage(img))
            {



                Brush brush = new SolidBrush(Color.Red);
                Font font = new System.Drawing.Font("Arial", 33, FontStyle.Bold, GraphicsUnit.Pixel);
                SizeF textSize = new SizeF();
                //var img_diag =Math.Sqrt((Math.Pow(Convert.ToDouble(img.Width),2.0))+ Math.Pow(Convert.ToDouble(img.Height), 2.0));
                textSize = grp.MeasureString(watermarkText, font);
                Point position = new Point(0, (int)(img.Height / 2) - (int)textSize.Height / 2);


                grp.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
                grp.RotateTransform(45);
                grp.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
                grp.DrawString(watermarkText, font, brush, position);

                grp.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
                grp.RotateTransform(-90);
                grp.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
                grp.DrawString(watermarkText, font, brush, position);

                Color color = Color.FromArgb(50, Color.Black);
                SolidBrush sb = new SolidBrush(color);

                grp.FillRectangles(sb, new RectangleF[] { new Rectangle(0, 0, img.Width, img.Height) });

                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    b64 = Convert.ToBase64String(ms.ToArray());
                }
            }
            return b64;
        }

        [Flags]
        private enum EmfToWmfBitsFlags
        {
            EmfToWmfBitsFlagsDefault = 0x00000000,
            EmfToWmfBitsFlagsEmbedEmf = 0x00000001,
            EmfToWmfBitsFlagsIncludePlaceable = 0x00000002,
            EmfToWmfBitsFlagsNoXORClip = 0x00000004
        }


        [DllImport("gdiplus.dll")]
        private static extern uint GdipEmfToWmfBits(IntPtr _hEmf, uint _bufferSize,
            byte[] _buffer, int _mappingMode, EmfToWmfBitsFlags _flags);
        [DllImport("gdi32.dll")]
        private static extern IntPtr SetMetaFileBitsEx(uint _bufferSize,
            byte[] _buffer);
        [DllImport("gdi32.dll")]
        private static extern IntPtr CopyMetaFile(IntPtr hWmf,
            string filename);
        [DllImport("gdi32.dll")]
        private static extern bool DeleteMetaFile(IntPtr hWmf);
        [DllImport("gdi32.dll")]
        private static extern bool DeleteEnhMetaFile(IntPtr hEmf);

        public static MemoryStream MakeMetafileStream(Bitmap image, string fname)
        {
            Metafile metafile = null;
            using (Graphics g = Graphics.FromImage(image))
            {
                IntPtr hDC = g.GetHdc();
                metafile = new Metafile(hDC, EmfType.EmfOnly);
                g.ReleaseHdc(hDC);
            }

            using (Graphics g = Graphics.FromImage(metafile))
            {
                g.DrawImage(image, 0, 0);
            }
            IntPtr _hEmf = metafile.GetHenhmetafile();
            uint _bufferSize = GdipEmfToWmfBits(_hEmf, 0, null, MM_ANISOTROPIC,
                EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
            byte[] _buffer = new byte[_bufferSize];
            GdipEmfToWmfBits(_hEmf, _bufferSize, _buffer, MM_ANISOTROPIC,
                    EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
            IntPtr hmf = SetMetaFileBitsEx(_bufferSize, _buffer);
            string tempfile = Path.GetTempFileName();
            //CopyMetaFile(hmf, tempfile);

            CopyMetaFile(hmf, fname);
            DeleteMetaFile(hmf);
            DeleteEnhMetaFile(_hEmf);

            //no use for stream yet !!!
            var stream = new MemoryStream();
            byte[] data = File.ReadAllBytes(tempfile);
            //File.Delete (tempfile);
            int count = data.Length;
            stream.Write(data, 0, count);
            return stream;
        }
    }
}
