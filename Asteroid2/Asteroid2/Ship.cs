using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid2
{
    public class Ship
    {
        public int x;
        public int y;
        public int dx;
        public int dy;
        public int cx;
        public int cy; 
        public int rad;
        SolidBrush sb;
        Pen pen;
        
        public Point[] sh = new Point[6];

        public Point[] tr = new Point[3];
        public Ship(SolidBrush sb, int x, int y  ,int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.sb = sb;
            
            tr[0].X = 330;
            tr[0].Y = 117;
            tr[1].X = 312;
            tr[1].Y = 128;
            tr[2].X = 350;
            tr[2].Y = 128;




            sh[0].X = x;
            sh[0].Y = y;
            sh[1].X = x;
            sh[1].Y = y - 30;
            sh[2].X = x + 30;
            sh[2].Y = y - 50;
            sh[3].X = x + 60;
            sh[3].Y = y - 30;
            sh[4].X = x + 60;
            sh[4].Y = y;
            sh[5].X = x + 30;
            sh[5].Y = y + 20;
            cx = x + 15;
            cy = y - 7;

        }

        public void Drawash(PaintEventArgs e)
        {
             sb = new SolidBrush(Color.Yellow);
            e.Graphics.FillPolygon(sb, sh);
            sb = new SolidBrush(Color.Green);
            e.Graphics.FillPolygon(sb, tr);
            e.Graphics.FillRectangle(sb, 327, 128, 8, 20);
            pen = new Pen(Color.Green,5);
            e.Graphics.DrawLine(pen, 340, 82, 340, 98);
            e.Graphics.DrawLine(pen, 332, 89, 349, 89);



        }
    }
}
