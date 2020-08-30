using System;

namespace milespergallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = 500.0;
            double gallons = 23.7;
            double mpg = miles / gallons;
            Console.WriteLine("mpg = "+mpg);
        }
    }
}
