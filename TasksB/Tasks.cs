using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksB
{
    class Tasks
    {
        //1.1
        public static double Calculation(double s, double t, double x)
        {
            return Math.Pow(Math.E, (0.5 * x)) / Math.Sqrt(x + (s * (Math.Log(Math.Pow(x, t)))));
        }

        //1.2
        public static int TakeByte(int n, int value)
        {
            if (value != 0)
            {
                return (n >> value & 1);
            }
            return -1;

        }

        public static int inverBitByIndex(int number, int value)
        {
            if (value != 0)
            {
                return number ^ value;
            }
            return (number & 1) ^ 1;
        }

        //1.4
        class IntCompotatorLess : IComparer
        {
            public int Compare(object x, object y)
            {
                return (int)y - (int)x;
            }
        }

        public static void f1(ref int x, ref int y, ref int z, ref int k, IComparer comp)
        {
            int[] temp = new int[] { x, y, z, k };
            Array.Sort(temp, comp);
            x = temp[0];
            y = temp[1];
            z = temp[2];
            k = temp[3];
        }

        //2.1.1
        public static int reverseNumber(int a)
        {
            int temp = 0;
            for (; a != 0; a /= 10)
            {
                temp *= 10;
                temp += a % 10;
            }
            return temp;
        }

        public static bool isPalindrom(int a)
        {
            return reverseNumber(a) == a;
        }

        //2.1.2
        public static int SumLast(int number, int k)
        {
            int sum = 0;
            for (int i = 0; i != k; ++i, number /= 10)
            {
                sum += number % 10;
            }
            return sum;
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

        //2.3
        public static void isPalindromPow(int number, int mun)
        {
            for (; number != mun; ++number)
            {
                if (isPalindrom(number) && isPalindrom((int)Math.Pow(number, 2)))
                    Console.WriteLine(number);
            }
        }

        //2.4
        public static int Fact(int number)
        {
            int res = 1;
            for (int i = 2; i != number; ++i)
            {
                res *= i;
            }
            return res;
        }
        public static double Calculation_3(double x, int n)
        {
            double res = 0;
            if (x > 0 && x <= 1)
            {
                for (int k = 0; k != n; ++k)
                {
                    double num = Math.Pow((-1), k) * Math.Pow(x, (4 * k + 1));
                    double denum = ((4 * k) + 1) * Fact(2 * k);
                    res += num / denum;
                }
            }
            return res;
        }

        //2.5
        public static bool simpleNumber(int value)
        {
            if (value == 1)
            {
                return false;
            }
            for (int i = 2; i != value; ++i)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void canonicalDecomposition_3(int value)
        {
            for (int i = 0; value != 1; ++i)
            {
                if (simpleNumber(i) && value % i == 0)
                {
                    Console.WriteLine(i);
                    value /= i;
                    i = 0;
                }
            }
        }

        //2.6.1
        public static int Calculation_(int[] arr, int d)
        {
            int temp = 0;
            int temp2 = 0;
            foreach (int item in arr)
            {
                if (arr[item + 1] == (arr[item] + d))
                {
                    ++temp;
                }
                else
                {
                    if (temp > temp2)
                    {
                        temp2 = temp;
                    }
                }
            }
            return temp2;
        }

        //2.6.2
        public static int k_diget_3(int value, int k)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i != k; ++i)
            {
                numbers.Add((int)Math.Pow(value, i));
            }
            return numbers[k - 1];
        }

        public static string K_digit_3_2(int k)
        {
            string pow = new string("1".ToCharArray());
            for (int i = 1; i < k; ++i)
            {
                pow = pow + Math.Pow(2, i);
            }
            return pow.ElementAt(k).ToString();
        }

        //3.1.1
        public static int[] TwoInOne(int[] arr, int[] arr2)
        {
            int[] res = new int[arr.Length + arr2.Length];
            arr.CopyTo(res, 0);
            arr2.CopyTo(res, arr.Length);
            Array.Sort(res);
            return res;
        }

        //3.4.1
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void SwapRows(int[,] arr, int firstRow, int secondRow)
        {
            int columns = arr.GetLength(1);
            for (int i = 0; i != columns; ++i)
            {
                Swap(ref arr[firstRow, i], ref arr[secondRow, i]);
            }
        }

        public static int[,] Vozr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, 0] > arr[i + 1, 0])
                    {
                        SwapRows(arr, i + 1, i);
                    }
                }
            }
            return arr;
        }

        //3.6.1
        public static List<HashSet<int>> BuildingMatrixB(List<List<int>> matrix)
        {
            List<HashSet<int>> res = new List<HashSet<int>>();
            int g = 0;
            foreach (List<int> i in matrix)
            {
                foreach (int j in i)
                {
                    res[g].Add(j);
                    ++g;
                }
                while (matrix[g].Count > res[g].Count)
                {
                    res[g].Add(0);
                }
                g = 0;
            }
            return res;
        }

        //3.7
        public static List<double> ArrayLongNumber(int d)
        {
            double res = Math.Pow(5, 100);
            double divisor = 0;
            List<double> finres = new List<double>();
            for (int i = 1; res - divisor <= 0; ++i)
            {
                divisor += d * Math.Pow(10, i - 1);
                finres.Add(divisor);
            }
            return finres;
        }

        //3.8
        public static int[,] PowMatrix(int[,] Matrix)
        {
            int[,] B = new int[Matrix.GetLength(0), Matrix.GetLength(1)];
            for (int i = 0; i != Matrix.GetLength(0); ++i)
            {
                for (int j = 0; j != Matrix.GetLength(1); ++j)
                {
                    B[i, j] = (int)Math.Pow(Matrix[i, j], 2);
                }
            }
            return B;
        }

        //4.1.1
        public static List<char> DeleteElText(string str)
        {
            int counter = 0;
            List<char> res = new List<char>(str);
            List<char> temp = new List<char>();
            for (int i = 0; i != res.Count; ++i)
            {
                for (int j = 0; j != res.Count; ++j)
                {
                    if (res[i] == res[j])
                    {
                        ++counter;
                    }
                }
                if (counter > 1)
                {
                    temp.Add(res[i]);
                }
                counter = 0;
            }
            return temp;
        }

        //4.2.1
        public static string ConvertTo(int value)
        {
            return Convert.ToString(value, 10);
        }

        //4.3
        public static bool NotPalindomStr(string str)
        {
            for (int i = 0, j = str.Length - 1; i != j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return true;
                }
            }
            return false;
        }


        public static string NotPalinStr(string str)
        {
            List<string> b = new List<string>(str.Split(' '));
            string res = " ";
            for (int i = 0; i != b.Count; ++i)
            {
                if (NotPalindomStr(b[i]) && (b[i].Length % 2 == 0))
                {
                    res += b[i];
                }
            }
            return res;
        }

        //4.4
        /*public static string EqualWord(string str)
        {
            List<string> b = new List<string>(str.Split(' '));
            for(int i = 0; i != b.Count; ++i)
            {
               b[i].Contains()
            }
        }*/

        //5.8
        public static void Selection_sort(int[] arr, int size)
        {
            for (int i = 1; i != size; ++i)
            {
                for (int j = i; j > 0 && arr[j] < arr[j - 1]; --j)
                {
                    Swap(ref arr[j], ref arr[j - 1]);
                }
            }
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void Bubble_sort(int[] arr)
        {
            for (int i = 0; i != arr.Length; ++i)
            {
                for (int j = 0; j != arr.Length - i; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        //5.9
        //Быстрая сортировка
        public static void QuickSort(int[] arr, int start, int end)
        {
            int i = start;
            int j = end;
            int x = arr[(start + end) / 2];
            while (i <= j)
            {
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                if (i <= j)
                {
                    Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            }
            if (start < j) QuickSort(arr, start, j);
            if (i < end) QuickSort(arr, i, end);
        }


        public static int PobochDiag(int[,] arr)
        {
            int res = 0;
            int x = (int)Math.Sqrt(arr.Length) - 1;
            for (int i = 0; i != Math.Sqrt(arr.Length); ++i)
            {
                res += arr[i, x - i];
            }
            return res;
        }

    }
}
