using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BasicSyntaxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            //Console.WriteLine("What's your age? ");
            var age = int.Parse(Console.ReadLine());
            //Console.WriteLine("What's yourID? ");
            var id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your salary? ");
            var salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Employee ID: {0:D8}", id);
            Console.WriteLine("Salary: {0:f2}", salary);
        }
    }
}
