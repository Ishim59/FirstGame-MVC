using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class BulletController
    {
        private BulletView _bulletView;
        private Bullet _bullet = new Bullet();
        public BulletController()
        {
            _bulletView = new BulletView();
        }
        public PictureBox PictureBullet => _bulletView.PictureBullet;
       
        public void PlayerLocation(PictureBox picturePlayer)
        {
            _bulletView.Turn(picturePlayer);
        }
        public void TargetMove(PictureBox player, Point targetLocation, Form form)
        {
            
            _bulletView.TargetMove(_bullet, player, targetLocation, form);
        }
        public void Move(Form form)
        {
            _bulletView.Move(form);
        }
        public void Dead(Form form)
        {
            _bulletView.Dead(form);
        }
    }
}
