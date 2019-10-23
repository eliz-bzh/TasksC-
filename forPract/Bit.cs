using System;
using System.Collections.Generic;
using System.Text;

namespace forPract
{
    class Bit
    {
        public static int Even(int number)
        {
            return number & 1;
        }

        public static void f(int number)
        {
            int zeroByte = number & int.MaxValue;
            int sevByte = number >> 7;
            int invert1 = number ^ 1;
            int invert3 = number ^ 4;
            int invertFinal = number ^ 5;
            Console.WriteLine(Convert.ToString(number, 2));
            Console.WriteLine(Convert.ToString(invert1, 2));
            Console.WriteLine(Convert.ToString(invert3, 2));
            Console.WriteLine(Convert.ToString(invertFinal, 2));
        }

        public static void f2(int number)
        {
            int zeroByte = number & int.MaxValue;
            int sevByte = number >> 7;
            Console.WriteLine(zeroByte + sevByte);
        }

        public static bool pow(int number)
        {
            return (number & (number - 1)) == 0 && number != 1;
        }

        public static int invert(int number)
        {
            return number ^ 2;
        }
    }
}
