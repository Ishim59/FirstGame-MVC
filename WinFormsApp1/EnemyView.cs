using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class EnemyView
    {
        //private List<Enemy> _enemy;
        //private Random rnd = new Random();

        //public EnemyView(List<Enemy> enemy)
        //{
        //    _enemy = enemy;
        //}
        //public void Paint(Graphics g)
        //{
        //    Brush b = new SolidBrush(Color.Aqua);
        //    foreach(var enemy in _enemy) 
        //    {
        //        g.FillRectangle(b, new Rectangle(enemy.X, enemy.Y, 30, 30));
        //    }
        //}
        private List<PictureBox> _enemies;
        private PictureBox _pictureEnemy;
        private Enemy _enemy = new Enemy();
       
        Random rnd = new Random();

        private int speed = 5;
        private int pts = 0;
        public string Pts => pts.ToString();


        public Point Location
        { 
            get => _pictureEnemy.Location;
            set => _pictureEnemy.Location = value;
        }
       
        public EnemyView(List<PictureBox> enemies, Form form)
        {
           
            _enemies = enemies;
            _pictureEnemy = new PictureBox();
            AddEnemy(form);
           
            
        }
        public void AddEnemy(Form form) 
        {
            _pictureEnemy.Location = new Point(
                rnd.Next(300, form.Width - _enemy.Size * 2),
                rnd.Next(form.Height - _enemy.Size * 2)
                );

            _pictureEnemy.Image = Properties.Resources.Мишень2;
            _pictureEnemy.Size = new Size(_enemy.Size, _enemy.Size);
            _pictureEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureEnemy.Name = "Enemy";
            form.Controls.Add(_pictureEnemy);
            _pictureEnemy.BackColor = Color.Transparent;
            _enemies.Add(_pictureEnemy);
        }

        public void Move(Form form)
        {
            var locX = _pictureEnemy.Location.X;
            var locY = _pictureEnemy.Location.Y;
            _pictureEnemy.Location = new Point(locX, locY + speed);
            if (locY + speed >= form.Height -100)
                speed = -speed;
            else if (locY - speed <= 10)
                speed = 5;
        }

        public bool Shoot(PictureBox pictureBullet, Form form)
        {
            return _pictureEnemy.Bounds.IntersectsWith(pictureBullet.Bounds);
        }
        public void Dead(PictureBox pictureBullet, Form form)
        {
            
            if(Shoot(pictureBullet,form))
            {
                _enemies.Clear();
                AddEnemy(form);
                pts += 1;
            }
        }
        

    }
        





        //public void Movement()
        //{
        //    int i;
        //    i = rnd.Next(6);
        //    switch(i)
        //    {
        //        case 0:
        //            locX += 5;
        //            break;
        //        case 1:
        //            locX -= 5;
        //            break;
        //        case 2:
        //            locY += 5;
        //            break;
        //        case 3:
        //            locY -= 5;
        //            break;
        //        case 4:
        //            locX += 5;
        //            locY += 5;
        //            break;
        //        case 5:
        //            locX += 5;
        //            locY -= 5;
        //            break;
        //        case 6:
        //            locX -= 5;
        //            locY += 5;
        //            break;
        //        case 7:
        //            locX -= 5;
        //            locY -= 5;
        //            break;
        //    }

        //}


    
}
