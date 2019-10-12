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
            /*int a = 4;
            int b = 3;
            int c = 2;
            int d = 5;*/

            /*Tasks.prinNumbers(456);
            Console.WriteLine(a + " " + b);
            Util.Swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Tasks.f1(ref a, ref b, ref c, ref d, new IntCompotatorLess());
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine(Tasks.allDifferent(new int[] { 1, 2, 3 }));
            Console.WriteLine(Tasks.countEqualElements(1265));
            Console.ReadKey();*/
            //Console.WriteLine(Tasks.CountK(0.989839, 3));
            Console.WriteLine(Tasks.Transposition(0.4565));
            Console.WriteLine(Tasks.SumsEqual(0.45351343, 2, 3));
            Console.ReadKey();

            int[] temp = new int[] { 4, 4, 8, 9, 9, 9, 7};
            int[] temp2 = new int[] { 1, 1, 2, 2, 3};
            /*ArrayList array = Tasks2.findEl(temp);
            foreach(var el in array)
            {
                Console.WriteLine(el);
            }
            
            int[] arr = Tasks2.findFiveGreat(temp);
            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }

            ArrayList res = Tasks2.copyArr(temp, temp2);
            foreach(var el in res)
            {
                Console.WriteLine(el);
            }*/
            

        }
    }
}
