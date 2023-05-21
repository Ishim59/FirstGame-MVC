using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class FieldController
    {
        private FieldView fieldView;
        public FieldController() 
        {
            fieldView = new FieldView();
        }
        public void Paint(Graphics g, Size containerSize)
        {
            fieldView.Paint(g, containerSize);
        }
    }
}
