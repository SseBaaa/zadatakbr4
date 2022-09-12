using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakbr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:Console.WriteLine("Unesi x");
            double x =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi z");
            double z = Convert.ToDouble(Console.ReadLine());

            if(x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("broj nesmije biti manji od nule!");
                goto start;
            }

            if(Math.Pow(z, 2) == Math.Pow(y, 2) + Math.Pow(x, 2))
            {
                Console.WriteLine("To je pravokutni trokut");
            }
            else
            {
                Console.WriteLine("To nije pravokutni trokut");
            }

            Console.ReadKey();
        }
    }
}
