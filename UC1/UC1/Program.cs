using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random_number = rnd.Next(3);
            String wage_per_hour;
            String hour;
            switch(random_number) 
            {
                case 0:
                    Console.WriteLine("Employee is Full Time");
                    Console.Write("Enter the wage per hour : ");
                    wage_per_hour = Console.ReadLine();
                    Console.Write("Enter number of hour : ");
                    hour = Console.ReadLine();
                    Console.WriteLine(Convert.ToInt32(wage_per_hour)*Convert.ToInt32(hour));
                    break;
                case 1:
                    Console.WriteLine("Employee is Part_Time");
                    Console.Write("Enter the wage per hour : ");
                    wage_per_hour = Console.ReadLine();
                    Console.Write("Enter number of hour : ");
                    hour = Console.ReadLine();
                    Console.WriteLine(Convert.ToInt32(wage_per_hour) * Convert.ToInt32(hour));
                    break;
                case 2:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            Console.ReadLine();

        }
    }
}
