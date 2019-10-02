using System;
using System.Collections;
namespace forPract
{
    class IntCompotatorLess : IComparer
    {
        public int Compare(object x, object y)
        {
            return (int)y - (int)x;
        }
    }
    class IntCompotatorGreat : IComparer
    {
        public int Compare(object x, object y)
        {
            return (int)x - (int)y;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            int c = 2;
            int d = 5;

            Tasks.prinNumbers(456);
            Console.WriteLine(a + " " + b);
            Util.Swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Tasks.f1(ref a, ref b, ref c, ref d, new IntCompotatorLess());
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine(Tasks.allDifferent(new int[] { 1, 2, 3 }));
            Console.WriteLine(Tasks.countEqualElements(1265));
            Console.ReadKey();
        }
    }
}
