using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class EnemyController
    {
       

        private List<PictureBox> _enemyList;
        private EnemyView _enemyView;
        Random rnd = new Random();  
        private Enemy _enemy = new Enemy();
        
        public EnemyController(Form form)
        {
            _enemyList = new List<PictureBox>();
            _enemyView = new EnemyView(_enemyList, form);
        }
        public void Move(Form form)
        {
            _enemyView.Move(form);
        }
        public string Pts => _enemyView.Pts;

       
        public bool Shoot(PictureBox pictureBullet,Form form)
        {
           return _enemyView.Shoot(pictureBullet,form);
        }
        public void Dead(PictureBox pictureBullet,Form form) 
        {
            _enemyView.Dead(pictureBullet, form);
        }
       
        
        
        
    }
}
