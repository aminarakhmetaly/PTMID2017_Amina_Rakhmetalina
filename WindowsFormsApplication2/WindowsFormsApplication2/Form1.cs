using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
  
    {
        public int a;
        public double A;
      //  public double B;
        public int b;
        //public double B;
        CalcClass calc = new CalcClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            calc.er = "";
            if (a > 0 ) // если равно уже нажали, на экране стоит результат 
            {
                display.Text = "0";
                a = 0;
            }
                if (display.Text == "0")
                {
                    display.Text = btn.Text;
                }
                else
                {
                    display.Text += btn.Text;
                }
            }
  

        private void coma_Click(object sender, EventArgs e)
        {
            if (display.Text == ",")
            {
                display.Clear();
                display.Text = "0,";
            }

            if (display.Text.IndexOf(",") == -1)
            {
                display.Text = display.Text + "," ;
            }
        }


        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            a = 0;
            b++;
           
            if (b == 1)
             {
                 calc.firstnumber = double.Parse(display.Text);
                 calc.operation = btn.Text;
                
            } 
             

            if (calc.operation != "V" && calc.operation != "1/X" && calc.operation != "X^2"  )
            {
                display.Text = "";
            }
            else
            {
                if (calc.er == "error")
                {
                    display.Clear();
                    display.Text = calc.er;
                }else
                {
                    calc.calculate();
                    display.Text = calc.result.ToString();
                }
               

            }
          
        }

        private void result_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            b = 0;
            if (display.Text == "")
            {
                if (calc.operation == "+")
                {
                    calc.result += calc.firstnumber;
                    display.Text = calc.result.ToString();

                }
               
                calc.result = 1;
                if (calc.operation == "x")
                {
                    calc.result *= calc.firstnumber;
                    display.Text = calc.result.ToString();

                }
                
            }

            a++;

           
            if (a == 1)
            {
               
                if (calc.operation != "V" && calc.operation != "1/X" && calc.operation != "X^2")
                {
                    calc.secondnumber = double.Parse(display.Text);
                    calc.calculate();
                    display.Text = calc.result.ToString();
                    A = calc.secondnumber;
               }
            }else
            {
                calc.firstnumber = double.Parse(display.Text);
                calc.secondnumber = A;
                calc.calculate();
                display.Text = calc.result.ToString();
            }

           


            if (display.Text == "не число")
            {
                display.Clear();
                display.Text = "error";
            }
            if (display.Text == "не число")
            {
                display.Clear();
                display.Text = "error";
            }
            if (display.Text == "∞")
            {
                display.Clear();
                display.Text = "error";
            }

          

        }
       

        private void sign_cick (object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            calc.sign = double.Parse(display.Text) * (-1);
            display.Text = calc.sign.ToString();

        }


        private void C_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
            calc.firstnumber = 0;
            calc.secondnumber = 0;
            calc.result = 0;
            calc.operation = "";
            A = 0;
            a = 0;
            b = 0;

        }

         private void CE_Click(object sender, EventArgs e)
         {
            display.Clear();
            display.Text = "0";
            calc = new CalcClass();


         }

        private void MS_click (object sender, EventArgs e)
        {
           
            Button btn = sender as Button;
            calc.memory = double.Parse(display.Text);
               
        }

        private void MR_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            display.Text = "";
            display.Text = calc.memory.ToString();

        }

        private void Mplus_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            calc.mplus = double.Parse(display.Text);
            calc.result = calc.memory + calc.mplus;
            calc.memory = calc.result;

        }

        private void Mminus_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            calc.mplus = double.Parse(display.Text);
            calc.result = calc.memory - calc.mplus;
            calc.memory = calc.result;

        }

        private void MC_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            calc.memory = 0;

        }

        private void del_click(object sender, EventArgs e)
        {
            string text = display.Text;
            int ind = text.Length - 1;
            text = text.Remove(ind);
            display.Text = text;
            if (display.Text == "")
            {
                display.Text = "0";
            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}


  

             