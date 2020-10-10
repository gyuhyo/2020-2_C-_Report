using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValueApp
{
    class CallByValue
    {
        static void ValueChange(int a, int b)
        {
            a = 20;
            b = 30;
            int sum = a + b;
            Console.WriteLine("ValueChange: a({0}) + b({1}) = {2}", a, b, sum);
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20, sum;
            sum = a + b;
            Console.WriteLine("Before: a({0}) + b({1}) = {2}", a, b, sum);
            ValueChange(a, b);
            sum = a + b;
            Console.WriteLine("After: a({0}) + b({1}) = {2}", a, b, sum);
        }
    }
}
