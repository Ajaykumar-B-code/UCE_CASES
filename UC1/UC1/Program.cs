using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int present = 1;
            int absent = 0;
            Random rand = new Random();
            int random_number = rand.Next(2);
            if(random_number == present) 
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
            Console.ReadLine();
        }
    }
}
