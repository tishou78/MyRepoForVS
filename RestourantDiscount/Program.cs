using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestourantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0.0;
            string hallName = null;

            if (countOfPeople <= 50)
            {
                price = 2500;
                hallName = "Small Hall";
            }
            else if (countOfPeople <= 100)
            {
                price = 5000;
                hallName = "Terrace";
            }
            else if (countOfPeople <= 120)
            {
                price = 7500;
                hallName = "Great Hall";
            }


            if (package == "Normal")
            {
                price += 500;
                price *= 0.95;
                price /= countOfPeople;
            }
            else if (package == "Gold")
            {
                price += 750;
                price *= 0.9;
                price /= countOfPeople;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price *= 0.85;
                price /= countOfPeople;
            }
            if (countOfPeople<= 120)
            {
                Console.WriteLine($"We can offer you the { hallName}");
                Console.WriteLine($"The price per person is { price:f2}$"); 
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
