using System;

namespace NumeralTypesandTypeConversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (comparingIntInput(a, b, c) && comparingIntInput(a, c, b) && comparingIntInput(b, c, a))
            {
                Console.WriteLine("Triangle is valid.");
                if (rightTriAngle(a, b, c))
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                else if (rightTriAngle(b, c, a))
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                else if (rightTriAngle(c, a, b))
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                else
                    Console.WriteLine("Triangle has no right angles");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }

        private static bool rightTriAngle(int i, int i1, int i2)
        {
            if (Math.Sqrt(i) + Math.Sqrt(i1) == Math.Sqrt(i2))
                return true;
            return false;
        }

        private static bool comparingIntInput(int i, int i1, int i2)
        {
            if (i + i1 > i2)
                return true;
            return false;
        }
    }
}