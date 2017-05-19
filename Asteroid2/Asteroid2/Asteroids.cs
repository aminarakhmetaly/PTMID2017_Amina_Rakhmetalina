using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid2
{
    class Asteroids
    {
        public int x;
        public int y;
        public int dx;
        public int dy;
        SolidBrush sb;
        public Point[] ast = new Point[12];

        public Asteroids(SolidBrush sb, int x, int y, int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.sb = sb;
            ast[0].X = x;
            ast[0].Y = y;
            ast[1].X = x - 5;
            ast[1].Y = y - 10;
            ast[2].X = x + 5;
            ast[2].Y = y - 10;
            ast[3].X = x + 10;
            ast[3].Y = y - 20;
            ast[4].X = x + 15;
            ast[4].Y = y - 10;
            ast[5].X = x + 25;
            ast[5].Y = y - 10;
            ast[6].X = x + 20;
            ast[6].Y = y;
            ast[7].X = x + 25;
            ast[7].Y = y + 10;
            ast[8].X = x + 15;
            ast[8].Y = y + 10;
            ast[9].X = x + 10;
            ast[9].Y = y + 20;
            ast[10].X = x + 5;
            ast[10].Y = y + 10;
            ast[11].X = x - 5;
            ast[11].Y = y + 10;

        }

        public void Drawast(PaintEventArgs e)
        {
            e.Graphics.FillPolygon(sb, ast);
        }
    }
}
