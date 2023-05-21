using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Bullet
    {
        private Image bulletImage;
        public Image BulletImage
        {
            get => bulletImage;
            set => bulletImage = value;
        }

        public Point Position { get; set; }
        
        public SizeF Shift { get; set; } = new SizeF(1f,1f);
        private PointF _target = new PointF(0f,0f);
        
        public Size BulletSize { get; set; } = new Size(20, 20);

        public int CenterX { get; set; }
        public int CenterY { get; set; }

        public Bullet()
        {
            bulletImage = Properties.Resources.Пуля3;
            Position = new Point(300,300);
           
        }
        public Image RotateImage(float angle)
        {
            Bitmap rotatedImage = new Bitmap(bulletImage.Width, bulletImage.Height);
            rotatedImage.SetResolution(bulletImage.HorizontalResolution, bulletImage.VerticalResolution);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(bulletImage.Width / 2, bulletImage.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-bulletImage.Width / 2, -bulletImage.Height / 2);
                g.DrawImage(bulletImage, new Point(0, 0));
            }
            return rotatedImage;
        }
       

    }
}
