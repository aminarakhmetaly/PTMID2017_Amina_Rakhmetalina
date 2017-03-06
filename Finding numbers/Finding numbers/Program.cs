using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (string i in args)
            {

                int p = int.Parse(i);
                for (int k = 1; k <= p; k++)

                {
                    if (int.Parse(i) % 3 == 0 && int.Parse(i) % 5 != 0)//checking whether number is 
                    {
                        Console.WriteLine(i);//taking solution
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}