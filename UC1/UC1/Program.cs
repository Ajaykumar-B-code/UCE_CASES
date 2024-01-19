using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int days = 0, hours = 0;
            while (days < 20 && hours < 100)
            {
                int val = rnd.Next(3);
                hours += val * 4;
                days++;
                Console.WriteLine($"val : {val}  Hours : {hours}   Days : {days}");
            }
            int wages = hours * 20;
            Console.WriteLine($"Wages : {wages}");
            Console.ReadKey();
        }
    }
}