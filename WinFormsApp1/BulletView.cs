using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class BulletView
    {
        private Bullet _bullet = new Bullet();
        private PictureBox _pictureBullet = new PictureBox();
        private int bulletSpeed = 20;
        double dx;
        double dy;
        public PictureBox PictureBullet => _pictureBullet;
        public BulletView() 
        {

        }

        public void Turn(PictureBox picturePlayer)
        {
            double radians = Math.Atan2(picturePlayer.Location.Y - _pictureBullet.Top - _bullet.CenterY, picturePlayer.Location.X - _pictureBullet.Left - _bullet.CenterX);
            double degrees = radians * (180 / Math.PI);
            _pictureBullet.Image = _bullet.RotateImage((float)degrees);
        }
        public void TargetMove(Bullet bullet,PictureBox player,Point targetLocation,Form form)
        {
            bool t = true;
            foreach (Control control in form.Controls)
            {
                if (control is PictureBox && control.Name == "Bullet")
                    t = false;
            }
            if (t)
            {
                _pictureBullet = new PictureBox();
                _bullet = bullet;
                _pictureBullet.Size = new Size(40, 9);
                _pictureBullet.Image = _bullet.BulletImage;
                _pictureBullet.SizeMode = PictureBoxSizeMode.StretchImage;
                _pictureBullet.Name = "Bullet";
                _pictureBullet.BackColor= Color.Transparent;
                form.Controls.Add(_pictureBullet);

                int playerX = player.Location.X + player.Width / 2 - _pictureBullet.Width / 2;
                int playerY = player.Location.Y + player.Height / 2 - _pictureBullet.Height / 2;

                _pictureBullet.Location = new Point(playerX, playerY);
                double angle = Math.Atan2(targetLocation.Y - player.Location.Y, targetLocation.X - player.Location.X);
                dx = bulletSpeed * Math.Cos(angle);
                dy = bulletSpeed * Math.Sin(angle);

            }

        }

        public void Move(Form form)
        {
            int newX = _pictureBullet.Location.X + (int)dx;
            int newY = _pictureBullet.Location.Y + (int)dy;
            _pictureBullet.Location = new Point(newX, newY);
            if (_pictureBullet.Location.X < 0 || _pictureBullet.Location.X > form.Width 
                || _pictureBullet.Location.Y < 0 || _pictureBullet.Location.Y > form.Height )
                _pictureBullet.Name = "NotBullet";
        }

        public void Dead(Form form)
        {
            form.Controls.Remove(_pictureBullet);
        }


    }
}
