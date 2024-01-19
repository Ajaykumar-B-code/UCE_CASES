using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int absent = 0;
            int part_time = 1;
            int present = 2;

            Random random = new Random();
            int random_number = random.Next(3);
            string wage_per_hour;
            string hour;
            if (random_number == absent)
            {
                Console.WriteLine("Employee is Absent");

            }
            else if (random_number == part_time)
            {
                Console.WriteLine("Employee is Part_time");
                Console.Write("Enter the wage per hour : ");
                wage_per_hour = Console.ReadLine();
                Console.Write("Enter number of hour : ");
                hour = Console.ReadLine();
                
                
            }
            else
            {
                Console.WriteLine("Employee is Full time");
                Console.Write("Enter the wage per hour : ");
                wage_per_hour = Console.ReadLine();
                Console.Write("Enter number of hour : ");
                hour = Console.ReadLine();
                Console.WriteLine(Convert.ToInt32(wage_per_hour) * Convert.ToInt32(hour));
            }
            Console.ReadLine();
        }
    }
}
