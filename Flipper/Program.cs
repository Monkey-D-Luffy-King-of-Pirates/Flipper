using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flipper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flipper(343434);
        }

        static void Flipper(double number)
        {
            double flipNumber = 0;
            double divider = 1;
            while (number % divider != number)
            {
                flipNumber = (flipNumber * 10) + ((number % (divider * 10)) - (number % divider)) / divider;
                divider *= 10;
            }
            Console.WriteLine(flipNumber);
        }
    }
}
