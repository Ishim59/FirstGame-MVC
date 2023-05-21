using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Player
    {

        private Image playerImage;
        public Point Location { get; private set; }
      
        public Image PlayerImage
        {
            get=> playerImage; set=>playerImage = value;
        }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public Player()
        {
            playerImage = Properties.Resources.Вправо;
            Location = new Point(100, 150);
        }
        public Image RotateImage(float angle)
        {
            Bitmap rotatedImage = new Bitmap(playerImage.Width, playerImage.Height);
            rotatedImage.SetResolution(playerImage.HorizontalResolution, playerImage.VerticalResolution);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(playerImage.Width / 2, playerImage.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-playerImage.Width / 2, -playerImage.Height / 2);
                g.DrawImage(playerImage, new Point(0, 0));
            }
            return rotatedImage;
        }
        



    }
}
