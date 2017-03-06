using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> div = new List<int>();
            List<int> nondiv = new List<int>();
            

            for (int i = 0; i < args.Length; i++)
            {
                if (int.Parse(args[i]) % 3 == 0)
                {
                    div.Add(int.Parse(args[i]));
                }
              
            }
            for (int i = 0; i < args.Length; i++)
            {
                if (int.Parse(args[i]) % 5 != 0)
                {
                    nondiv.Add(int.Parse(args[i]));
                }

            }
            Console.WriteLine("Numbers div by 3:");
            for (int i = 0; i < div.Count; i++)
            {
                Console.Write(div[i] + " ");
            }

            Console.WriteLine("\nNumbers nondiv by 5:");
            for (int i = 0; i < nondiv.Count; i++)
            {
                Console.Write(nondiv[i] + " ");
            }
            Console.ReadKey();

        }

       }
    }

