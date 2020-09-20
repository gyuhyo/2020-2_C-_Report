using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 25;
            int num2 = 10;

            Console.WriteLine("정수1 : " + num1);
            Console.WriteLine("정수2 : " + num2);
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
        }
    }
}
