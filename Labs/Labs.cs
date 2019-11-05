using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Labs
    {
        // 1
        public static void ChangeConsoleColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void LengthSquare(int d)
        {
            Console.WriteLine("Circumference" + " = " + (Math.PI * d));
            Console.WriteLine("Area of a circle" + " = " + (Math.PI * Math.Pow(d / 2, 2)));
        }

        public static int ConvertByteKilobytes(int bytes)
        {
            return bytes / 1000;
        }

        public static bool geometricProgression(int number)
        {
            int ed = number % 10;
            int des = (number / 10) % 10;
            int sot = (number / 100) % 10;
            return des == Math.Sqrt(ed * sot);
        }

        public static void f4()
        {
            for (int i = 100; i != 1000; ++i)
            {
                if (geometricProgression(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool triangle(int a, int b, int c)
        {
            return a + b + c >= 3;
        }

        public static double FunctionValue(int x)
        {
            double num = Math.Sin((Math.PI * Math.Pow(x, 2))) + Math.Log(Math.Pow(x, 2));
            double denum = Math.Sin((Math.PI * Math.Pow(x, 2))) + Math.Sin(x) + Math.Log(Math.Pow(x, 2)) + Math.Pow(x, 2) + Math.Pow(Math.E, Math.Cos(x));
            return num / denum;
        }
        public static double FunctionValue(double x)
        {
            double num = Math.Sin((Math.PI * Math.Pow(x, 2))) + Math.Log(Math.Pow(x, 2));
            double denum = Math.Sin((Math.PI * Math.Pow(x, 2))) + Math.Sin(x) + Math.Log(Math.Pow(x, 2)) + Math.Pow(x, 2) + Math.Pow(Math.E, Math.Cos(x));
            return num / denum;
        }
        public static double FunctionValue(float x)
        {
            double num = Math.Sin((Math.PI * Math.Pow(x, 2))) + Math.Log(Math.Pow(x, 2));
            double denum = Math.Sin((Math.PI * Math.Pow(x, 2))) + Math.Sin(x) + Math.Log(Math.Pow(x, 2)) + Math.Pow(x, 2) + Math.Pow(Math.E, Math.Cos(x));
            return num / denum;
        }

        public static bool F7(int x, int y, int r)
        {
            if(x >= 0)
            {
                if(r >= x && r >= y)
                {
                    return true;
                }
            }
            return false;
        }

        public static void F8()
        {
            Console.WriteLine("Vorobey lox");
        }

        //2
        public static int f1(int number)
        {
            if(number > 0)
            {
                return number += 1;
            }
            else if(number < 0)
            {
                return number -= 2;
            }
            return number = 10;
        }
    }
}
