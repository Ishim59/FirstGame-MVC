using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class FieldView
    {
        public void Paint(Graphics g, Size containerSize)
        {
            Pen p = new Pen(Color.Black);
            SolidBrush b = new SolidBrush(Color.Aqua);
            g.FillRectangle(b, 0, 0, 300, containerSize.Height);
            
            SolidBrush b2 = new SolidBrush(Color.Black);
            g.FillRectangle(b2, 300, 0, 10, containerSize.Height);

            SolidBrush b1 = new SolidBrush(Color.DarkGray);
            //g.FillRectangle(b1, 300, 0, containerSize.Width, containerSize.Height);

            g.DrawArc(p, 350, 100, 20, 20, 5,5);
        }
    }
}
