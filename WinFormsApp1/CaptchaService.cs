using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace WinFormsApp1.Services
{
    public class CaptchaService
    {
        private readonly Random _random = new Random();

        public string GenerateText(int length = 4)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(chars[_random.Next(chars.Length)]);
            }
            return result.ToString();
        }

        public Bitmap GenerateImage(string text, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.FromArgb(245, 245, 245));

                using (Pen noisePen = new Pen(Color.Silver, 1))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        g.DrawLine(noisePen, _random.Next(width), _random.Next(height), _random.Next(width), _random.Next(height));
                    }
                }

                string[] fontNames = { "Arial", "Verdana", "Georgia" };
                float charWidth = (float)width / text.Length;

                for (int i = 0; i < text.Length; i++)
                {
                    string fontName = fontNames[_random.Next(fontNames.Length)];
                    using (Font font = new Font(fontName, _random.Next(16, 20), FontStyle.Bold))
                    using (Brush brush = new SolidBrush(Color.FromArgb(_random.Next(0, 100), _random.Next(0, 100), _random.Next(0, 100))))
                    {
                        Matrix matrix = g.Transform;
                        float shiftX = (charWidth * i) + _random.Next(3, 6);
                        float shiftY = _random.Next(2, height / 5);

                        g.TranslateTransform(shiftX, shiftY);
                        g.RotateTransform(_random.Next(-10, 10));
                        g.DrawString(text[i].ToString(), font, brush, 0, 0);
                        g.Transform = matrix;
                    }
                }

                for (int i = 0; i < 40; i++)
                {
                    int x = _random.Next(width);
                    int y = _random.Next(height);
                    bitmap.SetPixel(x, y, Color.FromArgb(_random.Next(100, 200), _random.Next(100, 200), _random.Next(100, 200)));
                }
            }
            return bitmap;
        }
    }
}
