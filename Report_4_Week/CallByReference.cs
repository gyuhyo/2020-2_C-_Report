using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReferenceApp
{
    class CallByReference
    {
        static void ValueChange(ref int a, ref int b)
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
            ValueChange(ref a, ref b);
            sum = a + b;
            Console.WriteLine("After: a({0}) + b({1}) = {2}", a, b, sum);
        }
    }
}
