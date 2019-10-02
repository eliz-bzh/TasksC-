using System;
using System.Collections.Generic;
using System.Text;

namespace forPract
{
    class Util
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }

        static int min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;

        }
        static int min(int a, int b, int c)
        {
            return min(min(a, b), c);
        }
        static int max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;

        }
        static int max(int a, int b, int c)
        {
            return max(max(a, b), c);
        }

    }
}
