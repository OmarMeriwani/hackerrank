using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floor_and_ceiling_values
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            double num = Convert.ToDouble(temp);
            double mod = num % 1;
            if (mod == 0)
            {
                Console.WriteLine(num + " " + num);
            }
            else
            {
                double cieling = (num + (1 - mod));
                Console.WriteLine(num - mod + " "+ cieling);
            }
            Console.ReadLine();
        }
    }
}
