using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise1
    {
        static void Main (string [] args)
        {
            int x;
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            x = arr.Length;
            Console.Write(" Original array elements: ");

            show_array_elements(arr);
            shellSort(arr, x);

            Console.Write("\n   Sorted array elements: ");
            show_array_elements(arr);

            Console.ReadLine();
        }

        static void shellSort(int[] arr, int array_size)
        {
            int i, j, k=3, l;
            while (k > 0)
            {
                for(i=0;i<array_size; i++)
                {
                    j = i;
                    l = arr[i];
                    while((j>=k) && (arr[j - k] > l))
                    {
                        arr[j] = arr[j - k];
                        j -= k;
                    }
                    arr[j] = l;
                }
                if (k / 2 != 0)
                    k /= 2;
                else if (k == 1)
                    k = 0;
                else
                    k = 1;
            }
        }

        static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
                Console.Write(element + " ");
        }
    }
}
