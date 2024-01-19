using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wage_per_hour = 20;
            int total_hour = 8;
            int total_wage = wage_per_hour * total_hour;
            Console.WriteLine(total_wage);
            Console.ReadLine();
        }
    }
}