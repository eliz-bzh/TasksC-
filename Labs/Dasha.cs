using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Dasha
    {
        public static void first()
        {
            double h = (1 - 0.1) / 10; 
            for(double n = 0.1; n != 1; n += h)
            {
                double res = Math.Pow(Math.E, (n * Math.Cos(Math.PI / 4))) * Math.Cos(n * Math.Sin(Math.PI / 4));
                Console.WriteLine(res);
            }
        }

        public static double[] fillArray(double[] arr, int n)
        {
            Random rand = new Random();
            for(int i = 0; i != n; ++i)
            {
                arr[i] = Math.Round(rand.NextDouble(), 4);
                Console.WriteLine(arr[i]);
            }
            return arr;
        }

        public static double SubFirstSecond(double[] arr)
        {
            arr = fillArray(arr, 4);
            double min = arr.Min();
            double max = arr.Max();
            Console.WriteLine("Sub");
            return max - min;
        }

        public static int[,] MulMatrix(int[,] Matrix, int[,] Matrix2)
        {
            int[,] B = new int[Matrix.GetLength(0), Matrix.GetLength(1)];
            for (int i = 0; i != Matrix.GetLength(0); ++i)
            {
                for (int j = 0; j != Matrix.GetLength(1); ++j)
                {
                    B[i, j] = (int)Matrix[i, j] * Matrix2[i, j];
                    Console.WriteLine(B[i,j]);
                }
            }
            return B;
        }

        public static int[,] SumMatrix(int[,] Matrix, int[,] Matrix2)
        {
            int[,] B = new int[Matrix.GetLength(0), Matrix.GetLength(1)];
            for (int i = 0; i != Matrix.GetLength(0); ++i)
            {
                for (int j = 0; j != Matrix.GetLength(1); ++j)
                {
                    B[i, j] = (int)Matrix[i, j] + Matrix2[i, j];
                    Console.WriteLine(B[i, j]);
                }
            }
            return B;
        }

        public static List<int> fillArrayToInt(int n)
        {
            List<int> arr = new List<int>();
            Random rand = new Random();
            for (int i = 0; i != n; ++i)
            {
                arr.Add(rand.Next()/10000000);
                Console.WriteLine(arr[i]);
            }
            return arr;
        }

        public static int Arif(List<int> arr, int n)
        {
            int res = 0;
            for(int i = 0; i != n; ++i)
            {
                res += arr[i];
            }
            return res / n;
        }

        public static int SumGreaterOfArif(int n)
        {
            int res = 0;
            List<int> arr = new List<int>(fillArrayToInt(n));
            for(int i = 0; i != n; ++i)
            {
                if(arr[i] > Arif(arr, n))
                {
                    res += arr[i];
                }
            }
            return res;
        }
    }
}
