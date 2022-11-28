using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double I, R, r;
                Console.Write("Enter R");
                R = double.Parse(Console.ReadLine());
                Console.Write("Enter r");
                r = double.Parse(Console.ReadLine());
                I = 285 / (R + r * r);
                {
                    Console.WriteLine("I=" + I);
                }
            }
            
            catch (Exception)
         
        }
    }
}
