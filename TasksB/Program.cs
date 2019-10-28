using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(Tasks.Calculation(1,1,1));
            Console.WriteLine(Tasks.SumsEqual(0.1212, 2, 2));*/
            //Tasks.canonicalDecomposition_3(83006);
            int[,] Matrix = new int[3, 3]
                            {
                               { 1, 2, 0 },
                               { 1, 0, 3 },
                               { 0, 2, 3 }
                            };
            //int[] arr = { 1, 2, 3, 4, 0, 1, 2, 3, 4, 5 };
            //int[] arr1 = { 1, 2, 3 };
            /*Console.WriteLine(Tasks.PobochDiag(Matrix));
            Console.WriteLine(Tasks.Calculation_(arr, 1));
            //Tasks.k_diget_3(2, 8);
            Console.WriteLine(Tasks.TwoInOne(arr, arr1));
            foreach(int item in Tasks.TwoInOne(arr, arr1))
            {
                Console.Write(item + " ");
            }*/

            int[,] Matrix2 = new int[3, 3]
                            {
                               { 3, 2, 0 },
                               { 1, 0, 3 },
                               { 2, 2, 3 }
                            };

            /*Console.WriteLine(Tasks.k_diget_3(2,4));
            int[,] arr = Tasks.Vozr(Matrix2);

            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for(int i = 0; i < rows; ++i)
            {
                for(int j = 0; j != columns; ++j)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }

            int[,] Matrix3 = new int[3, 3]
                            {
                               { 3, 2, 1 },
                               { 0, 2, 3 },
                               { 0, 0, 3 }
                            };

            int[,] arr38 = Tasks.PowMatrix(Matrix3);

            int rows38 = arr38.GetLength(0);
            int columns38 = arr38.GetLength(1);
            for (int i = 0; i < rows38; ++i)
            {
                for (int j = 0; j != columns38; ++j)
                {
                    Console.Write(arr38[i, j]);
                }
                Console.WriteLine();
            }

            List<char> res = Tasks.DeleteElText("Hello");
            for(int i = 0; i != res.Count; ++i)
            {
                Console.WriteLine(res[i]);
            }*/

            //Console.WriteLine(Tasks.NotPalinStr("Hello world people"));
        }
    }
}
