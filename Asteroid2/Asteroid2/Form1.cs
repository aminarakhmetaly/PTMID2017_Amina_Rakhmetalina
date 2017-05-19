using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid2
{
    
   
    public partial class Form1 : Form
    {
        
        Stars star = new Stars(new SolidBrush(Color.White), 10, 10, 20, 20, 10, 10);
        Stars star1 = new Stars(new SolidBrush(Color.White), 400, 150, 20, 20, -7, 11);
        Stars star2 = new Stars(new SolidBrush(Color.White), 200, 300, 20, 20, -11, 8);
        Stars star3 = new Stars(new SolidBrush(Color.White), 100, 100, 20, 20, -8, -15);
        Stars star4 = new Stars(new SolidBrush(Color.White), 300, 250, 20, 20, 10, -10);
        Stars star5 = new Stars(new SolidBrush(Color.White), 580, 350, 20, 20, -14, -12);
        Stars star6 = new Stars(new SolidBrush(Color.White), 580, 20, 20, 20, 9, -12);
        Stars star7 = new Stars(new SolidBrush(Color.White), 20, 300, 20, 20, 8, -12);
        Asteroids asteroid = new Asteroids(new SolidBrush(Color.Red), 50, 70, 15, 10);
        Asteroids asteroid1 = new Asteroids(new SolidBrush(Color.Red), 480, 270, -11, -13);
        Asteroids asteroid2 = new Asteroids(new SolidBrush(Color.Red), 400, 100, 10, 5);
        Asteroids asteroid3 = new Asteroids(new SolidBrush(Color.Red), 150, 200, -15, -20);

        Ship ship = new Ship(new SolidBrush(Color.Yellow), 300, 150, 10, 10);
        
       
        

        public Form1()
        {
            InitializeComponent();
          
           
            label1.Text = "Level: 1 Score: 200  Live: ***";
           
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 608, 374);
            star.Drawst(e);
            star1.Drawst(e);
            star2.Drawst(e);
            star3.Drawst(e);
            star4.Drawst(e);
            star5.Drawst(e);
            star6.Drawst(e);
            star7.Drawst(e);
            asteroid.Drawast(e);
            asteroid1.Drawast(e);
            asteroid2.Drawast(e);
            asteroid3.Drawast(e);
          
            ship.Drawash(e);
            
            

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location + " ");
        }
    }
}
