using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace forPract
{
    class Tasks
    {
        public static void f1(ref int x, ref int y, ref int z, ref int k, IComparer comp)
        {
            int[] temp = new int[] { x, y, z, k};
            Array.Sort(temp, comp);
            x = temp[0];
            y = temp[1];
            z = temp[2];
            k = temp[3];
        }

        int reverseNumber(int a)
        {
            int temp = 0;
            for(; a != 0; a/=10)
            {
                temp = temp * 10;
                temp = temp + a % 10;
            }
            return temp;
        }

        bool isPalindrom(int a)
        {
            return reverseNumber(a) == a;
        }

        int beforeLastNum(int a, int n)
        {
            return (int)(a / Math.Pow(10, n)) % 10;
        }

        public static void prinNumbers(int a)
        {
            for(; a != 0; a /= 10)
            {
                Console.WriteLine(a % 10);
            }
        }

        public static bool allDifferent(int []a)
        {
            for(int i = 0; i != a.Length; ++i)
            {
                for(int j = i + 1; j != a.Length; ++j)
                {
                    if(a[i] == a[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static int sumOfDigit(int a)
        {
            int temp = 0;
            for(; a != 0; a /= 10)
            {
                temp += a % 10;
            }
            return temp;
        }
        public static int sumOfElementArray(int []a)
        {
            int temp = 0;
            for(int i = 0; i != a.Length; ++i)
            {
                temp += a[i];
            }
            return temp;
        }
        public static bool allDifferentt(int a)
        {
            for(int i = a; a != 0; i = i / 10)
            {
                for(int j = i / 10; j != 0; j = j / 10)
                {
                    if(i % 10 == j % 10)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int countEqualElements(int a)
        {
            int count = 0;
            for(int i = a; i != 0; i /= 10)
            {
                for(int j = i / 10; j != 0; j /= 10)
                {
                    if(i % 10 == j % 10)
                    {
                        ++count;
                    }
                }
            }
            return count;
        }
        public static bool isCountNelements(int a, int n)
        {
            return countEqualElements(a) == n;
        }
        
    }
}
