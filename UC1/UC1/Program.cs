using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  
            int random_number = rnd.Next(3);
            int wage_per_hour, hour,days;
            Console.Write("Enter the wage per hour : ");
            wage_per_hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of days: ");
            days = Convert.ToInt32(Console.ReadLine());
          
            if(random_number == 0) 
            {
                Console.WriteLine("Employee is Full time");
                Console.Write("Enter number of hour : ");
                hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(wage_per_hour * hour * days);
            }
            else if(random_number == 1) 
            {
                Console.WriteLine("Employee is part_time");
                Console.Write("Enter number of hour : ");
                hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(wage_per_hour * hour * days);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
