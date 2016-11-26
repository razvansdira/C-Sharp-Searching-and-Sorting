using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]
                {2,5,4,11,0,44,18,54,69,-8};
            Console.Write(" Original array: ");
            foreach (var item in arr)
                Console.Write(" " + item);

            quick_sort(arr, 0, arr.Length - 1);
            Console.Write("\n  Sorted array: ");

            foreach (var item in arr)
                Console.Write(" " + item);
            Console.ReadLine();
        }

        private static void quick_sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int pivot = partition(arr, l, r);
                if (pivot > 1)
                    quick_sort(arr, l, pivot - 1);
                if (pivot + 1 < r)
                    quick_sort(arr, pivot + 1, r);
            }
        }

        private static int partition(int[] arr, int l, int r)
        {
            int pivot = arr[l];
            while (true)
            {
                while (arr[l] < pivot)
                    l++;
                while (arr[r] > pivot)
                    r--;
                if (l < r)
                {
                    if (arr[l] == arr[r])
                        return r;
                    int x = arr[l];
                    arr[l] = arr[r];
                    arr[r] = x;
                }
                else
                    return r;
            }
        }
    }
}
