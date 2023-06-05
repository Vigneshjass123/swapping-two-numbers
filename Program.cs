using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping_two_numbers_without_using_third_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            {
                Console.WriteLine("a value is " + a +" b values is " + b);
            }
            Console.ReadKey();
        }
    }
}
