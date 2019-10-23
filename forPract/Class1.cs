using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace forPract
{
    class Tasks2
    {
        public static int[] findFiveGreat(int []arr)
        {
            SortedSet<int> array = new SortedSet<int>(arr, new GreatComparer());
            int[] result = new int[5];
            array.CopyTo(result, 0, 5);
            return result;
        }

        public static ArrayList intersectionInArray(int []first, int []second)
        {
            HashSet<int> arr1 = new HashSet<int>(first);
            HashSet<int> arr2 = new HashSet<int>(second);
            ArrayList result = new ArrayList();
            foreach(int i in arr1)
            {
                if(arr2.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static ArrayList copyArr(int [] arr1, int [] arr2)
        {
            ArrayList array = new ArrayList(arr1);
            foreach (int i in arr2)
            {
                array.Add(i);
            }
            array.Sort();
            return array;
        }
        public static ArrayList findEl(int[] arr)
        {
            ArrayList array = new ArrayList();
            HashSet<int> setArr = new HashSet<int>(arr);
            foreach (int i in setArr)
            {
                if (check(i, arr) > 1)
                {
                    array.Add(i);
                }

            }
            return array;
        }
        public static int check(int currentValue, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i != arr.Length; ++i)
            {
                if (currentValue == arr[i])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
