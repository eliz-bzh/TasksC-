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

        public static int reverseNumber(int a)
        {
            int temp = 0;
            for(; a != 0; a /= 10)
            {
                temp *= 10;
                temp += a % 10;
            }
            return temp;
        }

        bool isPalindrom(int a)
        {
            return reverseNumber(a) == a;
        }

        public static int beforeLastNum(int a, int n)
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
            for(int i = a; a != 0; i /= 10)
            {
                for(int j = i / 10; j != 0; j /= 10)
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

        public static int SumLast(int number, int k)
        {
            int sum = 0;
            for(int i = 0; i != k; ++i, number /= 10)
            {
                sum += number % 10;
            }
            return sum;
        }
        public static int CountEqualLast(int number, int k, int n)
        {
            int sum = 0;
            for (int i = 0; i != k; ++i, number /= 10)
            {
                if (number % 10 == n)
                    ++sum;
            }
            return sum;
        }

        public static int KDigit(double number, int k)
        {
            string numbe = number.ToString();
            int numbertran = Convert.ToInt32(numbe.Substring(numbe.IndexOf(",") + 1));
            numbertran = reverseNumber(numbertran);
            int count = CountEqualLast(numbertran, k, 9);
            return count;
        }

        public static int CountK(double number, int k)
        {
            string numbe = number.ToString();
            int numbertran = Convert.ToInt32(numbe.Substring(numbe.IndexOf(",") + 1));
            numbertran = reverseNumber(numbertran);
            int count = SumLast(numbertran, k);
            return count;
        }

        public static int Transposition(double number)
        {
            string numbe = number.ToString();
            int numbertran = Convert.ToInt32(numbe.Substring(numbe.IndexOf(",") + 1));
            numbertran = reverseNumber(numbertran);
            return numbertran;
        }


        public static bool SumsEqual(double number, int k, int n)
        {
            int sumK = CountK(number, k);
            int number1 = Convert.ToInt32(Math.Floor(Transposition(number) / Math.Pow(10, k)));
            int sumN = SumLast(number1, n);
            return sumK == sumN;
        }
    }
}
