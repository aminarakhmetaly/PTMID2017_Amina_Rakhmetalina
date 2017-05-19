using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication2
{
    public class CalcClass
    {

        public double firstnumber;
        public string operation;
        public double result;
        public double secondnumber;
        public double memory;
        public double mplus;
        public double sign;
        public string er;

        public void calculate()
        {
          
                switch (operation)
                {
                    case "+":

                        result = firstnumber + secondnumber;
                        break;
                    case "-":
                        result = firstnumber - secondnumber;
                        break;
                    case "/":
                        result = firstnumber / secondnumber;
                        break;
                    case "x":
                        result = firstnumber * secondnumber;
                        break;
                    case "%":
                        result = firstnumber / 100 * secondnumber;
                        break;
                    case "X^2":
                        result = firstnumber * firstnumber;
                        break;
              
                case "1/X":
                        result = 1 / firstnumber;
                    if (firstnumber == 0)
                    {
                        er = "error";
                    }
                        break;
                    case "V":
                        result = Math.Sqrt(firstnumber);
                    if (firstnumber < 0)
                    {
                        er = "error";
                    }
                    break;
                   
                    
                }
            }
            
        }

      


    }


