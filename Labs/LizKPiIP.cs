using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class LizKPiIP
    {
        //5
        public static StringBuilder Conversion(String s, int n)
        {
            StringBuilder sb = new StringBuilder(s);
            if (sb.Length > n)
            {
                sb.Remove(0, sb.Length - n - 1);
            }
            else if(sb.Length < n)
            {
                for(int i = sb.Length; i != n; ++i)
                {
                    sb.Insert(0, ".");
                }
            }
            return sb;
        }

        public static String Convertion(String s, int n)
        {
            if(s.Length > n)
            {
                s = s.Substring(s.Length - n, n);
            }
            else if(s.Length < n)
            {
                for(int i = s.Length; i != n; ++i)
                {
                    s = s.Insert(0, ".");
                }
            }
            return s;
        }

        //6
        public static DateTime[] fillArray(DateTime[] arr, int n)
        {
            Random random = new Random();
            DateTime start = new DateTime(2019, 11, 1, random.Next(6, 24), random.Next(0, 60), random.Next(0, 60));
            for (int i = 0; i != n; ++i)
            {
                arr[i] = start.AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60));
                Console.WriteLine(arr[i]);
            }
            return arr;
        }

        public static void Print(List<DateTime> dates)
        {
            for(int i = 0; i != dates.Count(); ++i)
            {
                Console.WriteLine(dates[i]);
            }
        }

        public static void f(DateTime[] dates, int size)
        {
            dates = fillArray(dates, size);
            DateTime startTime = new DateTime(2019, 11, 1, 7, 0, 0);
            List<DateTime> first = new List<DateTime>();
            List<DateTime> second = new List<DateTime>();
            for (int i = 0; i != dates.Length; ++i)
            {
                if (dates[i] >= startTime && startTime.AddHours(7) >= dates[i])
                {
                    first.Add(dates[i]);
                }
                else if(dates[i] >= startTime.AddHours(8) && startTime.AddHours(13) >= dates[i])
                {
                    second.Add(dates[i]);
                }
            }
            Console.WriteLine("Fisrt shift");
            Print(first);
            Console.WriteLine("Second shift");
            Print(second);
        }

        public static string ConverTo(int value)
        {
            string res = String.Format("{0:X}", value);
            return res;
        }
    }
}
