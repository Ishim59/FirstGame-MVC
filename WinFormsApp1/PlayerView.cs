using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public class PlayerView
    {
        
        private Player _player;
        private PictureBox _picturePlayer = new PictureBox();

        private int formX;
        private int formY;
        public Size ContainerSize { get; set; }
        public PictureBox PicturePlayer
        {
            get => _picturePlayer;
        }

        public PlayerView(Player player,Form form)
        {
            _player = player;
            _picturePlayer = new PictureBox();
            _player.CenterX = _picturePlayer.Width/ 2;
            _player.CenterY = _picturePlayer.Height/ 2;
            _picturePlayer.Image = _player.PlayerImage;
            _picturePlayer.BackColor = Color.Aqua;
            _picturePlayer.Location = _player.Location;
            _picturePlayer.SizeMode = PictureBoxSizeMode.AutoSize;
            formX = form.Width;
            formY = form.Height;
            form.Controls.Add(_picturePlayer);
        }

        

        public void MouseMove(object sender, MouseEventArgs e)
        {

            double radians = Math.Atan2(e.Y - _picturePlayer.Top - _player.CenterY, e.X - _picturePlayer.Left - _player.CenterX);
            double degrees = radians * (180 / Math.PI);
            _picturePlayer.Image = _player.RotateImage((float)degrees);

        }
        public void ChangeLocation(int dx,int dy)
        {
            var locX = _picturePlayer.Location.X;
            var locY = _picturePlayer.Location.Y;
            if (dx > 0 && locX + dx <= 200)
            {
                locX += dx;
            }
            if (dx <= 0 && locX - dx > 0) 
            {
                locX += dx;
            }
            if (dy > 0 && locY + dy <= formY - 150 )
            {
                locY += dy;
            }
            if (dy <= 0 && locY - dy > 0)
            {
                locY += dy;
            }
            _picturePlayer.Location = new Point(locX, locY);

        }
       



    }
}
