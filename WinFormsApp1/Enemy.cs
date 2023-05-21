using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Enemy
    {
        private Random rnd = new Random();
        public int Size { get; set; } =  60;
        public int rows = 3, space = 150;
        
    }
}
