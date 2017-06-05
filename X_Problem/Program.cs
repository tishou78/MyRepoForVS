using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;

            int o = n / 2;


            int t = n - 2;
            for (int j = o; j > 0; j--)
            {


                Console.Write(new string(' ', x));
                Console.Write("x");
                Console.Write(new string(' ', t));
                Console.WriteLine("x");
                x++;
                t -= 2;
            }
            Console.Write(new string(' ', x));
            Console.WriteLine("x");
            x--;
            int v = 1;
            for (int i = 0; i < o; i++)
            {
                Console.Write(new string(' ', x));
                Console.Write("x");
                Console.Write(new string(' ', v));
                Console.WriteLine("x");
                x--;
                v += 2;

            }
        }
    }
}
