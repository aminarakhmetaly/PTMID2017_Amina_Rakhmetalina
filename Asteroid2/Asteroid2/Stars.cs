using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asteroid2
{
    public class Stars
    {
        public int x;
        public int y;
        public int height;
        public int width;
        public int dx;
        public int dy;
        public int cx;
        public int cy;
        public int rad;
        SolidBrush sb;
        //public List<Stars> st;

        public Stars(SolidBrush sb, int x, int y, int width, int height, int dx, int dy)
        {
            this.sb = sb;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.dy = dy;
            this.dx = dx;
        }

        public Stars(SolidBrush sb, int x, int y, int width, int height)
        {
            this.sb = sb;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            rad = 10;
        }

        public void Drawst(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(sb, x, y, width, height);

        }
     }
  }


             
      
 
       
    

